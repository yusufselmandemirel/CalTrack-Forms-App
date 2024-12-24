using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
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
    public partial class frmAddMeal : Form
    {
        int mealId;
        int foodId;
        int _id;
        FoodMealService foodMealService;
        UserService userService;
        MealService mealService;
        FoodService foodService;
        Meal meal;
        FoodMeal foodMeal;
        public frmAddMeal(int id)
        {
            InitializeComponent();
            _id = id;
            mealService = new MealService();
            foodMealService = new FoodMealService();
            foodService = new FoodService();
            userService = new UserService();
            LoadCmbEnums();
            LoadCmbFood();
        }

        private void LoadCmbEnums()
        {
            cmbMeal.Items.Clear();

            cmbMeal.DataSource = Enum.GetValues(typeof(MealType));

        }


        private void LoadCmbFood()
        {
            cmbFood.DataSource = foodService.GetAll().Where(x => x.Status != Status.Deleted).ToList();
            cmbFood.DisplayMember = "Name";
            cmbFood.ValueMember = "Id";

        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cmbFood.SelectedItem;
            foodId = selectedFood.Id;
            string photoPath = selectedFood.PhotoPath;
            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
            {
                pbxFood.Image = Image.FromFile(photoPath);
            }
            else
            {

                pbxFood.Image = null;
            }
        }

        private void btnSaveMeal_Click(object sender, EventArgs e)
        {


            Food selectedFood = (Food)cmbFood.SelectedItem;

            var loggedInUser = userService.GetUserById(_id);
            foodMeal = new FoodMeal()
            {

                UserId = loggedInUser.Id,
                FoodId = selectedFood.Id,
                Portion = (double)nudPortion.Value,
                MealType = (MealType)cmbMeal.SelectedItem,




            };

            bool foodMealAddSucc = foodMealService.Add(foodMeal);
            if (foodMealAddSucc)
            {
                MessageBox.Show("Meal Added Successfully.");
            }
            else
            {
                MessageBox.Show("Error!");
            }



        }

        private void pbxFood_Click(object sender, EventArgs e)
        {

        }
    }
}
