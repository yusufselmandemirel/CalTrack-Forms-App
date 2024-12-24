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
using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
namespace CalTrack.UI
{
    public partial class frmUpdateUser : Form
    {
        int UserId;
        UserService userService;
        User User;
        public frmUpdateUser(int id)
        {
            InitializeComponent();
            UserId = id;
            userService = new UserService();
            LoadUserInfo();
        }
       
        private void LoadUserInfo()
        {
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            User =userService.GetUserById(UserId);
            txtFirstName.Text = User.Name;
            txtLastName.Text = User.LastName;
            txtUserName.Text = User.Username;
            txtPassword.Text = User.Password;
            cbGender.SelectedItem = User.gender;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User.Name = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.Username = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.gender = (Gender)cbGender.SelectedItem;

            bool updateUserSucc = userService.Update(User);
            if (updateUserSucc)
            {
                MessageBox.Show("User Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error Occurred While Updating User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
