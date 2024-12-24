namespace CalTrack.UI
{
    partial class frmUpdateMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMeal));
            pbxFood = new PictureBox();
            btnSaveMeal = new Button();
            btnBackMeal = new Button();
            label3 = new Label();
            label2 = new Label();
            nudPortion = new NumericUpDown();
            cmbFood = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbxFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPortion).BeginInit();
            SuspendLayout();
            // 
            // pbxFood
            // 
            pbxFood.Location = new Point(12, 69);
            pbxFood.Name = "pbxFood";
            pbxFood.Size = new Size(111, 100);
            pbxFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFood.TabIndex = 18;
            pbxFood.TabStop = false;
            // 
            // btnSaveMeal
            // 
            btnSaveMeal.BackColor = Color.ForestGreen;
            btnSaveMeal.Location = new Point(293, 329);
            btnSaveMeal.Name = "btnSaveMeal";
            btnSaveMeal.Size = new Size(75, 23);
            btnSaveMeal.TabIndex = 17;
            btnSaveMeal.Text = "Save";
            btnSaveMeal.UseVisualStyleBackColor = false;
            btnSaveMeal.Click += btnSaveMeal_Click;
            // 
            // btnBackMeal
            // 
            btnBackMeal.BackColor = Color.LightSeaGreen;
            btnBackMeal.Location = new Point(293, 12);
            btnBackMeal.Name = "btnBackMeal";
            btnBackMeal.Size = new Size(75, 23);
            btnBackMeal.TabIndex = 16;
            btnBackMeal.Text = "Back";
            btnBackMeal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 273);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Portion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 14;
            label2.Text = "Food:";
            // 
            // nudPortion
            // 
            nudPortion.Location = new Point(84, 265);
            nudPortion.Name = "nudPortion";
            nudPortion.Size = new Size(152, 23);
            nudPortion.TabIndex = 12;
            // 
            // cmbFood
            // 
            cmbFood.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFood.FormattingEnabled = true;
            cmbFood.Location = new Point(84, 210);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(152, 23);
            cmbFood.TabIndex = 10;
            cmbFood.SelectedIndexChanged += cmbFood_SelectedIndexChanged;
            // 
            // frmUpdateMeal
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
            Controls.Add(nudPortion);
            Controls.Add(cmbFood);
            Name = "frmUpdateMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUpdateMeal";
            ((System.ComponentModel.ISupportInitialize)pbxFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPortion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxFood;
        private Button btnSaveMeal;
        private Button btnBackMeal;
        private Label label3;
        private Label label2;
        private NumericUpDown nudPortion;
        private ComboBox cmbFood;
    }
}