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
    public partial class frmCategoryPage1 : Form
    {
        CategoryService categoryService;
        Category existingCategory;
        public frmCategoryPage1()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            lstCategoryLoad();
            btnCategoryUpdate.Enabled = false;
        }
        private void lstCategoryLoad()
        {
            var list = categoryService.GetAll().Select(x => new { x.Name, x.Id }).ToList();
            lstCategory.DataSource = list;
            lstCategory.DisplayMember = "Name";
            lstCategory.ValueMember = "Id";

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCategoryCreate_Click(object sender, EventArgs e)
        {
            // Check if the category name is empty
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category name cannot be empty.");
                return; // Exit the method without adding the category
            }

            // Check if a category with the same name already exists
            var existingCategories = categoryService.GetAll(); // Assuming this method returns all categories
            foreach (var existingCategory in existingCategories)
            {
                if (existingCategory.Name.Equals(txtCategoryName.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("A category with the same name already exists.");
                    return; // Exit the method if a duplicate category name is found
                }
            }

            // Proceed to add the new category if validation passes
            bool categorySuccess = categoryService.Add(txtCategoryName.Text);

            if (categorySuccess)
            {
                MessageBox.Show("Category added successfully.");
            }
            else
            {
                MessageBox.Show("Error adding category.");
            }

            // Reload the category list to reflect changes
            lstCategoryLoad();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            // Check if the category name is empty
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category name cannot be empty.");
                return; // Exit the method without updating the category
            }

            // Get the category ID from the selected category in the list
            int selectedCategoryId = (int)lstCategory.SelectedValue;

            // Check if a category with the same name already exists and is not deleted (excluding the current category)
            var existingCategories = categoryService.GetAll(); // Assuming this method returns all categories
            foreach (var existingCategory in existingCategories)
            {
                // Skip the current category being updated
                if (existingCategory.Id == selectedCategoryId) continue;

                // Check if the category name is the same and the status is not "deleted"
                if (existingCategory.Name.Equals(txtCategoryName.Text, StringComparison.OrdinalIgnoreCase) && existingCategory.Status != Status.Deleted)
                {
                    MessageBox.Show("A category with the same name already exists.");
                    return; // Exit if a duplicate category name is found
                }
            }

            // Proceed to update the category if no duplicate is found
            bool categoryUpdateSuccess = categoryService.Update(selectedCategoryId, txtCategoryName.Text);

            if (categoryUpdateSuccess)
            {
                MessageBox.Show("Category updated successfully.");
            }
            else
            {
                MessageBox.Show("Error updating category.");
            }

            // Reload the category list to reflect changes
            lstCategoryLoad();

        }

        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCategoryUpdate.Enabled = true;

        }



    }
}
