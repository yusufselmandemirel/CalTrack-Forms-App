using CalTrack.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalTrack.Core.Helpers;
using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Repo.Concretes;
namespace CalTrack.UI
{
    public partial class frmUsersPage : Form
    {
        int foodMealId;
        int foodId;
        int _id;
        UserService userService;
        FoodMealService foodMealService;
        FoodService foodService;
        private DateTime lastUpdated = DateTime.Now.Date;
        public frmUsersPage(int id)
        {
            InitializeComponent();
            userService = new UserService();
            foodMealService = new FoodMealService();
            _id = id;

            LoadUserInformation();
            LoadFoodMeals();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void LoadFoodMeals()//O gün içerisindeki statusu deleted olmayan mealtyperları datagridlerin içine yazar
        {
            dgvDinner.Columns.Clear();
            dgvBreakfast.Columns.Clear();
            dgvLunch.Columns.Clear();
            dgvSnacks.Columns.Clear();

            var startOfDay = DateTime.Today;
            var endOfDay = DateTime.Today.AddDays(1).AddMilliseconds(-1);

            var breakfastMeals = foodMealService.GetAll()//Farklı bir yol
                .Where(f => (int)f.Status != 2
                            && (int)f.MealType == 0
                            && f.CreateDate >= startOfDay && f.CreateDate <= endOfDay
                            && f.UserId == _id)
                .Select(f => new
                {
                    f.Id,
                    f.FoodId,
                    FoodName = f.Food.Name,
                    FoodPortion = f.Portion,
                    Calorie = f.Food.PortionCalorie * f.Portion
                })
                .ToList();

            dgvBreakfast.DataSource = breakfastMeals;

            dgvLunch.DataSource = foodMealService.GetAll().Where(x => x.Status != Status.Deleted && x.MealType == MealType.Lunch && x.CreateDate.Date == DateTime.Now.Date && x.UserId == _id).Select(x => new
            {
                x.Id,
                x.FoodId,
                FoodName = x.Food.Name,
                FoodPortion = x.Portion,
                Calorie = x.Food.PortionCalorie * x.Portion
            }).ToList();
            dgvDinner.DataSource = foodMealService.GetAll().Where(x => x.Status != Status.Deleted && x.MealType == MealType.Dinner && x.CreateDate.Date == DateTime.Now.Date && x.UserId == _id).Select(x => new
            {
                x.Id,
                x.FoodId,
                FoodName = x.Food.Name,
                FoodPortion = x.Portion,
                Calorie = x.Food.PortionCalorie * x.Portion
            }).ToList();
            dgvSnacks.DataSource = foodMealService.GetAll().Where(x => x.Status != Status.Deleted && x.MealType == MealType.Snacks && x.CreateDate.Date == DateTime.Now.Date && x.UserId == _id).Select(x => new
            {
                x.Id,
                x.FoodId,
                FoodName = x.Food.Name,
                FoodPortion = x.Portion,
                Calorie = x.Food.PortionCalorie * x.Portion
            }).ToList();
            dgvBreakfast.Columns["Id"].Visible = false;//Idler gözükmesin
            dgvBreakfast.Columns["FoodId"].Visible = false;
            dgvLunch.Columns["Id"].Visible = false;
            dgvLunch.Columns["FoodId"].Visible = false;
            dgvDinner.Columns["Id"].Visible = false;
            dgvDinner.Columns["FoodId"].Visible = false;
            dgvSnacks.Columns["Id"].Visible = false;
            dgvSnacks.Columns["FoodId"].Visible = false;

        }




        private void LoadUserInformation()
        {
            var loggedInUser = userService.GetUserById(_id);
            txtName.Text = loggedInUser.Name;
            txtUserPageAge.Text = loggedInUser.Age.ToString();
            txtUserPageGender.Text = loggedInUser.gender.ToString();
            txtUserPageHeight.Text = loggedInUser.Height.ToString();
            txtUserPageReqCalorie.Text = loggedInUser.DailyRequiredCalorie.ToString();
            txtUserPageSurname.Text = loggedInUser.LastName;
            txtUserPageWeight.Text = loggedInUser.Width.ToString();


        }
        private void frmUsersPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFoodMeal_Click(object sender, EventArgs e)
        {
            frmAddMeal frmAddMeal = new frmAddMeal(_id);
            frmAddMeal.FormClosed += (s, args) => LoadFoodMeals();
            frmAddMeal.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateMeal frmUpdate = new frmUpdateMeal(foodId, foodMealId, _id);
            frmUpdate.FormClosed += (s, args) => LoadFoodMeals();
            frmUpdate.ShowDialog();
        }

        private void dgvBreakfast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            int selectedIndex = e.RowIndex;
            if (selectedIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBreakfast.Rows[selectedIndex];

                foodId = Convert.ToInt32(selectedRow.Cells["FoodId"].Value);
                foodMealId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            }
        }

        private void dgvLunch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            int selectedIndex = e.RowIndex;
            if (selectedIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLunch.Rows[selectedIndex];

                foodId = Convert.ToInt32(selectedRow.Cells["FoodId"].Value);
                foodMealId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            }
        }

        private void dgvDinner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            int selectedIndex = e.RowIndex;
            if (selectedIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDinner.Rows[selectedIndex];

                foodId = Convert.ToInt32(selectedRow.Cells["FoodId"].Value);
                foodMealId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            }
        }

        private void dgvSnacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            int selectedIndex = e.RowIndex;
            if (selectedIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSnacks.Rows[selectedIndex];

                foodId = Convert.ToInt32(selectedRow.Cells["FoodId"].Value);
                foodMealId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this Meal?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);//Soru soruyor ve cevaba göre siliyor yada silmiyor

            if (confirmResult == DialogResult.Yes)//Yes seçerse sil
            {

                bool deleteResult = foodMealService.Delete(foodMealId);

                if (deleteResult)
                {
                    MessageBox.Show("Food deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Datagridleri
                    LoadFoodMeals();

                }
                else //No seçerse error ver
                {
                    MessageBox.Show("Error deleting the Food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports(_id);
            frmReports.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > lastUpdated) 
            {        lastUpdated = DateTime.Now.Date;
                LoadFoodMeals(); 
            }
        }
    }
}
