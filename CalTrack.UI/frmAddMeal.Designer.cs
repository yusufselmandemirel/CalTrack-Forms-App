namespace CalTrack.UI
{
    partial class frmAddMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMeal));
            cmbFood = new ComboBox();
            cmbMeal = new ComboBox();
            nudPortion = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBackMeal = new Button();
            btnSaveMeal = new Button();
            pbxFood = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudPortion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFood).BeginInit();
            SuspendLayout();
            // 
            // cmbFood
            // 
            cmbFood.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFood.FormattingEnabled = true;
            cmbFood.Location = new Point(84, 210);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(152, 23);
            cmbFood.TabIndex = 1;
            cmbFood.SelectedIndexChanged += cmbFood_SelectedIndexChanged;
            // 
            // cmbMeal
            // 
            cmbMeal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeal.FormattingEnabled = true;
            cmbMeal.Location = new Point(84, 13);
            cmbMeal.Name = "cmbMeal";
            cmbMeal.Size = new Size(152, 23);
            cmbMeal.TabIndex = 2;
            // 
            // nudPortion
            // 
            nudPortion.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPortion.Location = new Point(84, 265);
            nudPortion.Name = "nudPortion";
            nudPortion.Size = new Size(152, 23);
            nudPortion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Meal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Food:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 273);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Portion:";
            // 
            // btnBackMeal
            // 
            btnBackMeal.BackColor = Color.LightSeaGreen;
            btnBackMeal.Location = new Point(293, 12);
            btnBackMeal.Name = "btnBackMeal";
            btnBackMeal.Size = new Size(75, 23);
            btnBackMeal.TabIndex = 7;
            btnBackMeal.Text = "Back";
            btnBackMeal.UseVisualStyleBackColor = false;
            // 
            // btnSaveMeal
            // 
            btnSaveMeal.BackColor = Color.ForestGreen;
            btnSaveMeal.Location = new Point(293, 329);
            btnSaveMeal.Name = "btnSaveMeal";
            btnSaveMeal.Size = new Size(75, 23);
            btnSaveMeal.TabIndex = 8;
            btnSaveMeal.Text = "Save";
            btnSaveMeal.UseVisualStyleBackColor = false;
            btnSaveMeal.Click += btnSaveMeal_Click;
            // 
            // pbxFood
            // 
            pbxFood.Location = new Point(12, 69);
            pbxFood.Name = "pbxFood";
            pbxFood.Size = new Size(111, 100);
            pbxFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFood.TabIndex = 9;
            pbxFood.TabStop = false;
            pbxFood.Click += pbxFood_Click;
            // 
            // frmAddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 382);
            Controls.Add(pbxFood);
            Controls.Add(btnSaveMeal);
            Controls.Add(btnBackMeal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudPortion);
            Controls.Add(cmbMeal);
            Controls.Add(cmbFood);
            Name = "frmAddMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Meal";
            ((System.ComponentModel.ISupportInitialize)nudPortion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFood;
        private ComboBox cmbMeal;
        private NumericUpDown nudPortion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBackMeal;
        private Button btnSaveMeal;
        private PictureBox pbxFood;
    }
}