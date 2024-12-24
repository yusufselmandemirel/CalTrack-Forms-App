using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Core.Helpers;
using CalTrack.Service.Services;


namespace CalTrack.UI
{
    public partial class frmSignupPage : Form
    {
       private UserService userService;
        public frmSignupPage()
        {
            InitializeComponent();
            userService = new UserService();
            cmbEnums();
        }

        private void cmbEnums()
        {
            cbActivityLevel.Items.Clear();
            cbGender.Items.Clear();
            cbGender.DataSource=Enum.GetValues(typeof(Gender));
            cbActivityLevel.DataSource=Enum.GetValues(typeof(ActivityLevel));
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txtUserName.Text,
                Password = txtPassword.Text,
                Name = txtFirstName.Text,
                LastName = txtLastName.Text,
                Height = (double)nudHeight.Value,
                Width = (double)nudWidth.Value,
                BirthDate = dtpBirthDate.Value,
                gender = (Gender)cbGender.SelectedItem,
                ActivityLevel = (ActivityLevel)cbActivityLevel.SelectedItem,
                City = txtCity.Text,
                //Age= Ages.CalculateAge(dtpBirthDate.Value)


            };

            bool signupSuccess=userService.Add(user);
            if (signupSuccess)
            {
                MessageBox.Show("User Added Successfully.");
            }
        }
    }
}
