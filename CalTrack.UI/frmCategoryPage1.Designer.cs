namespace CalTrack.UI
{
    partial class frmCategoryPage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryPage1));
            lstCategory = new ListBox();
            btnClose = new Button();
            label1 = new Label();
            txtCategoryName = new TextBox();
            btnCategoryUpdate = new Button();
            btnCategoryCreate = new Button();
            SuspendLayout();
            // 
            // lstCategory
            // 
            lstCategory.FormattingEnabled = true;
            lstCategory.ItemHeight = 15;
            lstCategory.Location = new Point(15, 162);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(398, 124);
            lstCategory.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSeaGreen;
            btnClose.Location = new Point(338, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 9;
            label1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(34, 53);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(174, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.BackColor = Color.ForestGreen;
            btnCategoryUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryUpdate.Location = new Point(214, 81);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(75, 23);
            btnCategoryUpdate.TabIndex = 6;
            btnCategoryUpdate.Text = "Update";
            btnCategoryUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCategoryCreate
            // 
            btnCategoryCreate.BackColor = Color.DodgerBlue;
            btnCategoryCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryCreate.Location = new Point(214, 52);
            btnCategoryCreate.Name = "btnCategoryCreate";
            btnCategoryCreate.Size = new Size(75, 23);
            btnCategoryCreate.TabIndex = 7;
            btnCategoryCreate.Text = "Add";
            btnCategoryCreate.UseVisualStyleBackColor = false;
            // 
            // frmCategoryPage1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(434, 312);
            Controls.Add(lstCategory);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtCategoryName);
            Controls.Add(btnCategoryUpdate);
            Controls.Add(btnCategoryCreate);
            Name = "frmCategoryPage1";
            Text = "frmCategoryPage1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCategory;
        private Button btnClose;
        private Label label1;
        private TextBox txtCategoryName;
        private Button btnCategoryUpdate;
        private Button btnCategoryCreate;
    }
}