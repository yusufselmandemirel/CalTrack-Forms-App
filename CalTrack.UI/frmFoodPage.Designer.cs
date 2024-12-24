namespace CalTrack.UI
{
    partial class frmFoodPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodPage));
            label1 = new Label();
            txtFoodName = new TextBox();
            btnFoodDelete = new Button();
            btnFoodCreate = new Button();
            btnClose = new Button();
            txtPhotoPath = new TextBox();
            cmbCategoryAdd = new ComboBox();
            nudPortionCalorie = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdateFood = new Button();
            dgvFood = new DataGridView();
            pbxFood = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudPortionCalorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Food";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(45, 47);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(174, 23);
            txtFoodName.TabIndex = 6;
            txtFoodName.KeyPress += txtFoodName_KeyPress;
            // 
            // btnFoodDelete
            // 
            btnFoodDelete.BackColor = Color.Firebrick;
            btnFoodDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoodDelete.Location = new Point(300, 90);
            btnFoodDelete.Name = "btnFoodDelete";
            btnFoodDelete.Size = new Size(75, 23);
            btnFoodDelete.TabIndex = 4;
            btnFoodDelete.Text = "Delete";
            btnFoodDelete.UseVisualStyleBackColor = false;
            btnFoodDelete.Click += btnFoodDelete_Click;
            // 
            // btnFoodCreate
            // 
            btnFoodCreate.BackColor = Color.DodgerBlue;
            btnFoodCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoodCreate.Location = new Point(300, 24);
            btnFoodCreate.Name = "btnFoodCreate";
            btnFoodCreate.Size = new Size(75, 23);
            btnFoodCreate.TabIndex = 5;
            btnFoodCreate.Text = "Add";
            btnFoodCreate.UseVisualStyleBackColor = false;
            btnFoodCreate.Click += btnFoodCreate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSeaGreen;
            btnClose.Location = new Point(461, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(45, 155);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(174, 23);
            txtPhotoPath.TabIndex = 11;
            // 
            // cmbCategoryAdd
            // 
            cmbCategoryAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryAdd.FormattingEnabled = true;
            cmbCategoryAdd.Location = new Point(45, 101);
            cmbCategoryAdd.Name = "cmbCategoryAdd";
            cmbCategoryAdd.Size = new Size(174, 23);
            cmbCategoryAdd.TabIndex = 13;
            // 
            // nudPortionCalorie
            // 
            nudPortionCalorie.Location = new Point(45, 209);
            nudPortionCalorie.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPortionCalorie.Name = "nudPortionCalorie";
            nudPortionCalorie.Size = new Size(174, 23);
            nudPortionCalorie.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 15;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 132);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 15;
            label3.Text = "Photo Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 186);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 15;
            label4.Text = "Portion Calorie";
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.BackColor = Color.ForestGreen;
            btnUpdateFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.Location = new Point(300, 53);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(75, 31);
            btnUpdateFood.TabIndex = 16;
            btnUpdateFood.Text = "Update";
            btnUpdateFood.UseVisualStyleBackColor = false;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // dgvFood
            // 
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFood.BackgroundColor = Color.PeachPuff;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(12, 257);
            dgvFood.Name = "dgvFood";
            dgvFood.RowTemplate.Height = 25;
            dgvFood.Size = new Size(524, 150);
            dgvFood.TabIndex = 17;
            dgvFood.CellClick += dgvFood_CellClick;
            // 
            // pbxFood
            // 
            pbxFood.Location = new Point(280, 130);
            pbxFood.Name = "pbxFood";
            pbxFood.Size = new Size(128, 102);
            pbxFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFood.TabIndex = 18;
            pbxFood.TabStop = false;
            // 
            // frmFoodPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(548, 419);
            Controls.Add(pbxFood);
            Controls.Add(dgvFood);
            Controls.Add(btnUpdateFood);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudPortionCalorie);
            Controls.Add(cmbCategoryAdd);
            Controls.Add(txtPhotoPath);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Controls.Add(btnFoodDelete);
            Controls.Add(btnFoodCreate);
            Name = "frmFoodPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodPage";
            ((System.ComponentModel.ISupportInitialize)nudPortionCalorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFoodName;
        private Button btnFoodDelete;
        private Button btnFoodCreate;
        private Button btnClose;
        private TextBox txtPhotoPath;
        private ComboBox cmbCategoryAdd;
        private NumericUpDown nudPortionCalorie;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnUpdateFood;
        private DataGridView dgvFood;
        private PictureBox pbxFood;
    }
}