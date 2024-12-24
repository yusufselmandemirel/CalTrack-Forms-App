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
    public partial class frmStartPage : Form
    {
        int id;
        UserService userService;
        public frmStartPage()
        {
            InitializeComponent();
            userService = new UserService();
            txtPassword.PasswordChar = '*';
        }

        private void frmStartPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            frmSignupPage frmSingupPage = new frmSignupPage();
            frmSingupPage.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var existingUser = userService.GetAll().FirstOrDefault(x => x.Username == txtUserName.Text);

            //If user not found
            if (existingUser == null)
            {
                MessageBox.Show("Username not found.");
                return;
            }

            //If password matches
            if (existingUser.Password == txtPassword.Text) // In a real app, compare hashed password
            {
                //Check if it's the admin user (Id == 1)
                if (existingUser.Id == 1)
                {
                    frmAdminPage frmAdminPage = new frmAdminPage();
                    frmAdminPage.ShowDialog();
                }
                else
                {
                    id = existingUser.Id;
                    frmUsersPage frmUsersPage = new frmUsersPage(id);
                    frmUsersPage.ShowDialog();

                }
            }
            else
            {
                //Password does not match
                MessageBox.Show("Invalid password.");
            }
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Şifreyi göster

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
