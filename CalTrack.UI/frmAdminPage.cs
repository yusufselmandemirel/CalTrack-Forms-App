using CalTrack.Core.Concretes;
using CalTrack.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalTrack.UI
{
    public partial class frmAdminPage : Form
    {
        int UserId;
        UserService userService;
        public frmAdminPage()
        {
            InitializeComponent();

            userService = new UserService();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            frmFoodPage frmFoodPage = new frmFoodPage();
            frmFoodPage.ShowDialog();
        }

        private void btnPasifKullanıcılar_Click(object sender, EventArgs e)
        {

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            frmCategoryPage1 frmCategoryPage = new frmCategoryPage1();
            frmCategoryPage.ShowDialog();
        }

        private void btnActiveUsers_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = userService.GetAll().Where(x => x.Status != Core.Enums.Status.Deleted).Select(x => new { x.Id, x.Name, x.LastName, x.Username, x.Password, x.gender, x.CreateDate }).ToList();
        }

        private void btnPassiveUsers_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = userService.GetAll().Where(x => x.Status == Core.Enums.Status.Deleted).Select(x => new { x.Id, x.Name, x.LastName, x.Username, x.Password, x.gender, x.CreateDate }).ToList();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            if (selectedIndex > 0)
            {
                DataGridViewRow selectedRow = dgvUsers.Rows[selectedIndex];

                UserId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser frmUpdateUser = new frmUpdateUser(UserId);
            frmUpdateUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this User?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);//Soru soruyor ve cevaba göre siliyor yada silmiyor

            if (confirmResult == DialogResult.Yes)//Yes seçerse sil
            {

                bool deleteResult = userService.Delete(UserId);

                if (deleteResult)
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                }
                else //No seçerse error ver
                {
                    MessageBox.Show("Error deleting the User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
