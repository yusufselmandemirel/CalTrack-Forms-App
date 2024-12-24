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
    public partial class frmUpdateMeal : Form
    {
        int _userId;
        int _foodMealId;
        int _foodId;
        FoodMeal _foodMeal;
        FoodService _foodService;
        FoodMealService _foodMealService;
        public frmUpdateMeal(int foodId, int foodMealId, int userId)
        {
            InitializeComponent();
            _foodId = foodId;
            _foodMealId = foodMealId;
            _userId = userId;
            _foodService = new FoodService();
            _foodMealService = new FoodMealService();
            LoadFood();
            LoadFoodInformation();
        }
        private void LoadFoodInformation()
        {
            var selectedFoodMeal = _foodMealService.GetFoodMealById(_foodMealId);
            var selectedFood = _foodService.GetFoodById(_foodId);
            cmbFood.Text = selectedFood.Name.ToString();
            nudPortion.Value = (decimal)selectedFoodMeal.Portion;
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
        private void LoadFood()
        {

            cmbFood.Items.Clear();
            cmbFood.DataSource = _foodService.GetAll().Where(x => x.Status != Status.Deleted).ToList();
            cmbFood.DisplayMember = "Name";
            cmbFood.ValueMember = "Id";




        }
        private void btnSaveMeal_Click(object sender, EventArgs e)
        {
            _foodMeal = _foodMealService.GetFoodMealById(_foodMealId);
            if (_foodMeal is not null)
            {
                Food selectedFood = (Food)cmbFood.SelectedItem;
                _foodMeal.Portion = (double)nudPortion.Value;
                _foodMeal.UserId = _userId;
                _foodMeal.FoodId = selectedFood.Id;
                bool foodMealUpdatSucc = _foodMealService.Update(_foodMeal);
                if (foodMealUpdatSucc)
                {
                    MessageBox.Show("Food Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error Occurred While Adding New Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cannot find Food!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cmbFood.SelectedItem;
            _foodId = selectedFood.Id;
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
    }
}
