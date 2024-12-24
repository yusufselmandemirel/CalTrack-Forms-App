namespace CalTrack.UI
{
    partial class frmAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPage));
            btnKategoriEkle = new Button();
            btnYemekEkle = new Button();
            btnDelete = new Button();
            btnUpdateUser = new Button();
            btnActiveUsers = new Button();
            dgvUsers = new DataGridView();
            btnPassiveUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(473, 75);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(122, 27);
            btnKategoriEkle.TabIndex = 0;
            btnKategoriEkle.Text = "Add Category";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(473, 146);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(122, 27);
            btnYemekEkle.TabIndex = 0;
            btnYemekEkle.Text = "Add Food";
            btnYemekEkle.UseVisualStyleBackColor = true;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(171, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(171, 75);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(122, 27);
            btnUpdateUser.TabIndex = 3;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnActiveUsers
            // 
            btnActiveUsers.Location = new Point(171, 262);
            btnActiveUsers.Name = "btnActiveUsers";
            btnActiveUsers.Size = new Size(122, 27);
            btnActiveUsers.TabIndex = 5;
            btnActiveUsers.Text = "Get Active Users";
            btnActiveUsers.UseVisualStyleBackColor = true;
            btnActiveUsers.Click += btnActiveUsers_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 336);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(709, 177);
            dgvUsers.TabIndex = 6;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnPassiveUsers
            // 
            btnPassiveUsers.Location = new Point(473, 262);
            btnPassiveUsers.Name = "btnPassiveUsers";
            btnPassiveUsers.Size = new Size(122, 27);
            btnPassiveUsers.TabIndex = 7;
            btnPassiveUsers.Text = "Get Passive Users";
            btnPassiveUsers.UseVisualStyleBackColor = true;
            btnPassiveUsers.Click += btnPassiveUsers_Click;
            // 
            // frmAdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(733, 525);
            Controls.Add(btnPassiveUsers);
            Controls.Add(dgvUsers);
            Controls.Add(btnActiveUsers);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnDelete);
            Controls.Add(btnYemekEkle);
            Controls.Add(btnKategoriEkle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmAdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Page";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKategoriEkle;
        private Button btnYemekEkle;
        private Label label1;
        private Label label4;
        private Button btnDelete;
        private Button btnUpdateUser;
        private Button button3;
        private Button btnActiveUsers;
        private DataGridView dgvUsers;
        private Button btnPassiveUsers;
    }
}