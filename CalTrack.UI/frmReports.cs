using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Core.Abstracts;
using CalTrack.Repo.Concretes;
using CalTrack.Repo.Contexts;
using CalTrack.Service.Services;
using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalTrack.UI
{
    public partial class frmReports : Form
    {
        int _userId;
        FoodService _foodService;
        FoodMealService _foodMealService;
        UserService _userService;
        AppDbContext _appDbContext;
        public frmReports(int id)
        {
            InitializeComponent();
            _foodMealService = new FoodMealService();
            _userService = new UserService();
            _foodService = new FoodService();
            _appDbContext = new AppDbContext();
            _userId = id;
            LoadReportTypes();
            dgvReport.DataSource = null;
            btnReportByDate.Enabled = false;
        }
        private void LoadDailyCalories()
        {

            var list = (from fm in _appDbContext.FoodMeals
                        join u in _appDbContext.Users on fm.UserId equals u.Id
                        join f in _appDbContext.Foods on fm.FoodId equals f.Id
                        where fm.Status != Core.Enums.Status.Deleted
                        group new { fm, f } by fm.MealType into g

                        orderby g.Key
                        select new
                        {
                            MealType = g.Key,  // The MealType enum value
                            TotalCalories = g.Sum(x => x.fm.Portion * x.f.PortionCalorie),  // Calculate total calories
                            Count = g.Count(),  // Count how many records per MealType
                            Foods = g.Select(x => x.fm.FoodId).ToList()  // List distinct FoodIds per MealType
                        }).ToList();

            var totalCaloriesAllMealTypes = list.Sum(x => x.TotalCalories);
            nudDailyCalorie.Value = (decimal)totalCaloriesAllMealTypes;
        }
        public void LoadReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.DataSource = Enum.GetValues(typeof(ReportType));
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMealType = cmbReportType.SelectedItem.ToString(); // Get the selected item as a string

            if (Enum.TryParse(selectedMealType, out ReportType selectedEnum))
            {
                // Enum successfully parsed
                // Now you can use selectedEnum, which is of type MealType
                if (selectedEnum == ReportType.DailyReport)
                {
                    labelCalorie.Visible = true;
                    nudDailyCalorie.Visible = true;
                    LoadDailyCalories();
                    var list = (from fm in _appDbContext.FoodMeals
                                join u in _appDbContext.Users on fm.UserId equals u.Id
                                join f in _appDbContext.Foods on fm.FoodId equals f.Id
                                where fm.Status != Core.Enums.Status.Deleted
                                select new { fm, f })
                               .AsEnumerable()  //Çektiğimiz veri listesine sorgu atıyoruz
                               .Where(x => x.fm.CreateDate.Date == DateTime.Now.Date)  // Bellekte tarih filtresi uygula
                               .GroupBy(x => x.fm.MealType)  // Öğün türüne göre grupla
                               .OrderBy(g => g.Key)  // Öğün türüne göre sırala
                               .Select(g => new
                               {
                                   MealType = g.Key,  // Öğün türü
                                   TotalCalories = g.Sum(x => x.fm.Portion * x.f.PortionCalorie),  // Toplam kalori
                                   Count = g.Count(),  // Bu öğün türünde toplam öğün sayısı
                                   Foods = g.Select(x => x.fm.FoodId).ToList()  // Yenen yemeklerin benzersiz listesi
                               })
                               .ToList();



                    dgvReport.DataSource = list;

                }
                else if (selectedEnum == ReportType.MostEatenFoods)
                {
                    var result = (
                    from fm in _appDbContext.FoodMeals
                    join f in _appDbContext.Foods on fm.FoodId equals f.Id
                    where fm.Status != Core.Enums.Status.Deleted // Silinmiş olan yemekleri dışla
                    group fm by f.Name into g  // Yiyeceğe göre gruplama
                    orderby g.Count() descending // En çok yenen yemekler
                    select new
                    {
                        FoodName = g.Key,   // Yemek adı
                        TotalCount = g.Count() // Bu yemeğin kaç kez yenildiği
                    })
                    .ToList(); // Sonuçları listeye al

                    // Sonuçları DataGridView'e bağlamak
                    dgvReport.DataSource = result;
                }
                else if (selectedEnum == ReportType.FoodMealReport)
                {
                    var result = (
                from fm in _appDbContext.FoodMeals
                join f in _appDbContext.Foods on fm.FoodId equals f.Id
                where fm.Status != Core.Enums.Status.Deleted // Silinmiş yemekleri dışla
                group new { fm, f } by new { fm.MealType, f.Name } into g // Öğün türü ve yemek adı ile grupla
                orderby g.Key.MealType, g.Sum(x => x.fm.Portion) descending // Öğün türüne ve toplam porsiyon sayısına göre sıralama
                select new
                {
                    MealType = g.Key.MealType, // Öğün türü (Kahvaltı, Öğle, Akşam vb.)
                    FoodName = g.Key.Name, // Yemek adı
                    TotalPortion = g.Sum(x => x.fm.Portion) // Bu yemekten toplam kaç porsiyon yenmiş
                })
                .AsEnumerable()
                .GroupBy(x => x.MealType) // MealType'a göre gruplama
                .SelectMany(g => g.Take(1)) // Her öğün türü için en fazla porsiyon olan yemeği seç
                .ToList(); // Sonuçları listeye al

                    // Sonuçları DataGridView'e bağlamak
                    dgvReport.DataSource = result;
                }

            }
        }

        private void btnReportByDate_Click(object sender, EventArgs e)
        {
            var startDate = dtpStartDate.Value;  // Başlangıç tarihi
            var endDate = dtpEndDate.Value;     // Bitiş tarihi
            if (startDate > endDate)
            {
                // Kullanıcıya geçersiz tarih aralığı hakkında bilgi veririz
                MessageBox.Show("Wrong Start Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = (
            from fm in _appDbContext.FoodMeals
            join u in _appDbContext.Users on fm.UserId equals u.Id
            join f in _appDbContext.Foods on fm.FoodId equals f.Id
            where fm.Status != Core.Enums.Status.Deleted
            select new { fm, u, f }) // Sadece gerekli veriler seçiliyor
            .AsEnumerable() // Çektiğimiz veri listesine sorgu atıyoruz
            .Where(x => x.fm.CreateDate >= startDate && x.fm.CreateDate <= endDate) // Bellekte tarih filtresi uygulamak
            .GroupBy(x => new { FullName = x.u.Name + " " + x.u.LastName, x.fm.MealType }) // Kullanıcı adı ve soyadı birleştirip grupla
            .OrderBy(g => g.Key.FullName) // Kullanıcı adına göre sıralama
            .ThenBy(g => g.Key.MealType) // Öğün türüne göre sıralama
            .Select(g => new
            {
                User = g.Key.FullName, // Kullanıcı adı ve soyadı birleştirilmiş şekilde
                MealType = g.Key.MealType, // Öğün türü
                TotalCount = g.Count() // Bu öğün türünde toplam öğün sayısı
            })
            .ToList();

            // Sonuçları bir DataGridView veya benzeri bir kontrolle göstermek için
            dgvReport.DataSource = result;
            dgvReport.Columns["User"].DisplayIndex = 0; // "User" sütununu en başa al
            dgvReport.Columns["MealType"].DisplayIndex = 1; // "MealType" sütununu ikinci sıraya al
            dgvReport.Columns["TotalCount"].DisplayIndex = 2;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            btnReportByDate.Enabled = true;
        }
    }
}
