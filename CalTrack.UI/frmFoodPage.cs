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
using CalTrack.Core.Abstracts;
using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Core.Helpers;
namespace CalTrack.UI
{
    public partial class frmFoodPage : Form
    {
        int _selectedFoodId;
        FoodService foodService;
        CategoryService categoryService;
        Food _Food;
        public frmFoodPage()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            foodService = new FoodService();
            btnFoodDelete.Enabled = false;
            btnUpdateFood.Enabled = false;
            LoadFoodDataGrid();
            
        }
        private void LoadFoodDataGrid()
        {
            cmbCategoryLoad();
            var list = foodService.GetAll().Where(x => x.Status != Status.Deleted).ToList();
            dgvFood.DataSource = list;

        }
        private void cmbCategoryLoad()
        {
            cmbCategoryAdd.DataSource = categoryService.GetAll().Select(c => new { c.Name, c.Id }).ToList();
            cmbCategoryAdd.DisplayMember = "Name";
            cmbCategoryAdd.ValueMember = "Id";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, space, and backspace (delete) keys
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;  // Ignore the key press if it's not allowed
            }
        }

        private void btnFoodCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text) ||
        nudPortionCalorie.Value <= 0 ||
        cmbCategoryAdd.SelectedValue == null ||
        string.IsNullOrWhiteSpace(txtPhotoPath.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if any required field is missing
            }

            var existingFoods = foodService.GetAll(); // Assuming a method that returns all foods
            foreach (var existingFood in existingFoods)
            {
                if (existingFood.Name.Equals(txtFoodName.Text, StringComparison.OrdinalIgnoreCase) && existingFood.Status != Status.Deleted)
                {
                    MessageBox.Show("A food item with the same name already exists.");
                    return; //Exit if a food with the same name already exists and is not deleted
                }
            }
            // Create a new Food object
            Food food = new Food()
            {
                Name = txtFoodName.Text,
                CategoryId = (int)cmbCategoryAdd.SelectedValue,
                PhotoPath = txtPhotoPath.Text,
                PortionCalorie = (double)nudPortionCalorie.Value
            };

            // Add the new food to the database
            bool foodAddedSuccess = foodService.Add(food);

            if (foodAddedSuccess)
            {
                MessageBox.Show("Food Added Successfully.");
            }
            else
            {
                MessageBox.Show("Error adding food.");
            }

            // Reload the data grid to reflect changes
            LoadFoodDataGrid();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            // Check if the selected food exists
            _Food = foodService.GetFoodById(_selectedFoodId);
            if (_Food is null)
            {
                MessageBox.Show("Food not found.");
                return; // Exit the method if food does not exist
            }

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtFoodName.Text) ||
                nudPortionCalorie.Value <= 0 ||
                cmbCategoryAdd.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtPhotoPath.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if any required field is missing
            }
            var existingFoods = foodService.GetAll(); // Assuming GetAllFoods retrieves all food records
            foreach (var existingFood in existingFoods)
            {
                // Skip the food being updated
                if (existingFood.Id == _Food.Id) continue;

                // Check if the food name is the same and the status is not "deleted"
                if (existingFood.Name.Equals(txtFoodName.Text, StringComparison.OrdinalIgnoreCase) && existingFood.Status !=Status.Deleted)
                {
                    MessageBox.Show("A food item with the same name already exists.");
                    return; // Exit if a duplicate food name is found that is not deleted
                }
            }

            // Proceed to update the food if all validations pass
            _Food.Name = txtFoodName.Text;
            _Food.PortionCalorie = (double)nudPortionCalorie.Value;
            _Food.CategoryId = (int)cmbCategoryAdd.SelectedValue;
            _Food.PhotoPath = txtPhotoPath.Text;

            bool foodUpdateSuccess = foodService.Update(_Food);

            if (foodUpdateSuccess)
            {
                MessageBox.Show("Food Updated Successfully.");
            }
            else
            {
                MessageBox.Show("Error updating food.");
            }

            // Reload the data grid to reflect changes
            LoadFoodDataGrid();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            if (selectedIndex > 0)
            {
                DataGridViewRow selectedRow = dgvFood.Rows[selectedIndex];
                string photoPath = selectedRow.Cells["PhotoPath"].Value.ToString();
                if (File.Exists(photoPath))
                {
                    // Load the image into the PictureBox
                    pbxFood.Image = Image.FromFile(photoPath);
                }
                else
                {
                    
                    pbxFood.Image = null;  // Clear the image if not found
                }
                int foodId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                txtFoodName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPhotoPath.Text = selectedRow.Cells["PhotoPath"].Value.ToString();
                nudPortionCalorie.Value = Convert.ToDecimal(selectedRow.Cells["PortionCalorie"].Value);
                cmbCategoryAdd.SelectedValue = selectedRow.Cells["CategoryId"].Value;
                _selectedFoodId = foodId;
                btnFoodDelete.Enabled = true;
                btnUpdateFood.Enabled = true;
            }
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            bool deleteFoodSuccess = foodService.Delete(_selectedFoodId);

            if (deleteFoodSuccess)
            {
                MessageBox.Show("Food Deleted Successfully.");
                
            }
            else
            {
                MessageBox.Show("Error!");

            }
            LoadFoodDataGrid();
        }
    }
}
