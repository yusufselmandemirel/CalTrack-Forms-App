namespace CalTrack.UI
{
    partial class frmUsersPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersPage));
            dgvBreakfast = new DataGridView();
            btnAddFoodMeal = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReports = new Button();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtUserPageSurname = new TextBox();
            txtUserPageAge = new TextBox();
            txtUserPageHeight = new TextBox();
            txtUserPageGender = new TextBox();
            txtUserPageWeight = new TextBox();
            txtUserPageReqCalorie = new TextBox();
            labelB = new Label();
            dgvLunch = new DataGridView();
            dgvDinner = new DataGridView();
            dgvSnacks = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtName = new TextBox();
            label14 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSnacks).BeginInit();
            SuspendLayout();
            // 
            // dgvBreakfast
            // 
            dgvBreakfast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBreakfast.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBreakfast.BackgroundColor = Color.BlanchedAlmond;
            dgvBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakfast.Location = new Point(12, 38);
            dgvBreakfast.Name = "dgvBreakfast";
            dgvBreakfast.RowTemplate.Height = 25;
            dgvBreakfast.Size = new Size(345, 150);
            dgvBreakfast.TabIndex = 4;
            dgvBreakfast.CellClick += dgvBreakfast_CellClick;
            // 
            // btnAddFoodMeal
            // 
            btnAddFoodMeal.BackColor = Color.DodgerBlue;
            btnAddFoodMeal.Location = new Point(456, 311);
            btnAddFoodMeal.Name = "btnAddFoodMeal";
            btnAddFoodMeal.Size = new Size(89, 33);
            btnAddFoodMeal.TabIndex = 5;
            btnAddFoodMeal.Text = "Add";
            btnAddFoodMeal.UseVisualStyleBackColor = false;
            btnAddFoodMeal.Click += btnAddFoodMeal_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.YellowGreen;
            btnUpdate.Location = new Point(456, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Location = new Point(456, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 33);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DarkOrange;
            btnReports.Location = new Point(664, 708);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(151, 51);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(648, 417);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 16;
            label7.Text = "Daily Required Calorie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(648, 381);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 16;
            label4.Text = "Weight:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(648, 310);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 16;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(648, 239);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 16;
            label6.Text = "Surname:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(648, 197);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 16;
            label8.Text = "Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(648, 278);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 16;
            label9.Text = "Age:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(648, 343);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 16;
            label10.Text = "Height:";
            // 
            // txtUserPageSurname
            // 
            txtUserPageSurname.Enabled = false;
            txtUserPageSurname.Location = new Point(827, 231);
            txtUserPageSurname.Name = "txtUserPageSurname";
            txtUserPageSurname.Size = new Size(100, 23);
            txtUserPageSurname.TabIndex = 18;
            // 
            // txtUserPageAge
            // 
            txtUserPageAge.Enabled = false;
            txtUserPageAge.Location = new Point(827, 270);
            txtUserPageAge.Name = "txtUserPageAge";
            txtUserPageAge.Size = new Size(100, 23);
            txtUserPageAge.TabIndex = 20;
            // 
            // txtUserPageHeight
            // 
            txtUserPageHeight.Enabled = false;
            txtUserPageHeight.Location = new Point(827, 335);
            txtUserPageHeight.Name = "txtUserPageHeight";
            txtUserPageHeight.Size = new Size(100, 23);
            txtUserPageHeight.TabIndex = 21;
            // 
            // txtUserPageGender
            // 
            txtUserPageGender.Enabled = false;
            txtUserPageGender.Location = new Point(827, 302);
            txtUserPageGender.Name = "txtUserPageGender";
            txtUserPageGender.Size = new Size(100, 23);
            txtUserPageGender.TabIndex = 22;
            // 
            // txtUserPageWeight
            // 
            txtUserPageWeight.Enabled = false;
            txtUserPageWeight.Location = new Point(827, 378);
            txtUserPageWeight.Name = "txtUserPageWeight";
            txtUserPageWeight.Size = new Size(100, 23);
            txtUserPageWeight.TabIndex = 23;
            // 
            // txtUserPageReqCalorie
            // 
            txtUserPageReqCalorie.Enabled = false;
            txtUserPageReqCalorie.Location = new Point(827, 417);
            txtUserPageReqCalorie.Name = "txtUserPageReqCalorie";
            txtUserPageReqCalorie.Size = new Size(100, 23);
            txtUserPageReqCalorie.TabIndex = 24;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.BackColor = Color.Transparent;
            labelB.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelB.ForeColor = SystemColors.Control;
            labelB.Location = new Point(12, 12);
            labelB.Name = "labelB";
            labelB.Size = new Size(76, 20);
            labelB.TabIndex = 26;
            labelB.Text = "Breakfast";
            // 
            // dgvLunch
            // 
            dgvLunch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLunch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLunch.BackgroundColor = Color.BlanchedAlmond;
            dgvLunch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLunch.Location = new Point(12, 247);
            dgvLunch.Name = "dgvLunch";
            dgvLunch.RowTemplate.Height = 25;
            dgvLunch.Size = new Size(345, 150);
            dgvLunch.TabIndex = 27;
            dgvLunch.CellClick += dgvLunch_CellClick;
            // 
            // dgvDinner
            // 
            dgvDinner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDinner.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDinner.BackgroundColor = Color.BlanchedAlmond;
            dgvDinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDinner.Location = new Point(12, 458);
            dgvDinner.Name = "dgvDinner";
            dgvDinner.RowTemplate.Height = 25;
            dgvDinner.Size = new Size(345, 139);
            dgvDinner.TabIndex = 28;
            dgvDinner.CellClick += dgvDinner_CellClick;
            // 
            // dgvSnacks
            // 
            dgvSnacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSnacks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSnacks.BackgroundColor = Color.BlanchedAlmond;
            dgvSnacks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSnacks.Location = new Point(12, 663);
            dgvSnacks.Name = "dgvSnacks";
            dgvSnacks.RowTemplate.Height = 25;
            dgvSnacks.Size = new Size(345, 150);
            dgvSnacks.TabIndex = 29;
            dgvSnacks.CellClick += dgvSnacks_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(12, 224);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 26;
            label11.Text = "Lunch";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(12, 428);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 26;
            label12.Text = "Dinner";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(12, 640);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 26;
            label13.Text = "Snacks";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(827, 187);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(701, 125);
            label14.Name = "label14";
            label14.Size = new Size(165, 25);
            label14.TabIndex = 31;
            label14.Text = "User Information";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmUsersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(999, 826);
            Controls.Add(label14);
            Controls.Add(txtName);
            Controls.Add(dgvSnacks);
            Controls.Add(dgvDinner);
            Controls.Add(dgvLunch);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(labelB);
            Controls.Add(txtUserPageReqCalorie);
            Controls.Add(txtUserPageWeight);
            Controls.Add(txtUserPageGender);
            Controls.Add(txtUserPageHeight);
            Controls.Add(txtUserPageAge);
            Controls.Add(txtUserPageSurname);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(btnReports);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddFoodMeal);
            Controls.Add(dgvBreakfast);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmUsersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Page";
            Load += frmUsersPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSnacks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBreakfast;
        private Button btnAddFoodMeal;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReports;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox txtUserPageSurname;
        private TextBox txtUserPageAge;
        private TextBox txtUserPageHeight;
        private TextBox txtUserPageGender;
        private TextBox txtUserPageWeight;
        private TextBox txtUserPageReqCalorie;
        private Label labelB;
        private DataGridView dgvLunch;
        private DataGridView dgvDinner;
        private DataGridView dgvSnacks;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private TextBox txtName;
        private Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}