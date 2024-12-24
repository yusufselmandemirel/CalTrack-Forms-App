namespace CalTrack.UI
{
    partial class frmSignupPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignupPage));
            txtUserName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCity = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cbGender = new ComboBox();
            cbActivityLevel = new ComboBox();
            nudHeight = new NumericUpDown();
            nudWidth = new NumericUpDown();
            label1 = new Label();
            btnKayit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(302, 69);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(59, 69);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(59, 119);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(59, 275);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 23);
            txtCity.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(59, 169);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 1;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(59, 222);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 23);
            cbGender.TabIndex = 2;
            // 
            // cbActivityLevel
            // 
            cbActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActivityLevel.FormattingEnabled = true;
            cbActivityLevel.Location = new Point(302, 275);
            cbActivityLevel.Name = "cbActivityLevel";
            cbActivityLevel.Size = new Size(200, 23);
            cbActivityLevel.TabIndex = 2;
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(302, 169);
            nudHeight.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(200, 23);
            nudHeight.TabIndex = 3;
            // 
            // nudWidth
            // 
            nudWidth.Location = new Point(302, 222);
            nudWidth.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(200, 23);
            nudWidth.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 51);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(427, 304);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(75, 23);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "Signup";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 101);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 151);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "BirthDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 204);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 257);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 51);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 4;
            label6.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(302, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 107);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 4;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(302, 151);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 4;
            label8.Text = "Height";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(302, 204);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 4;
            label9.Text = "Weight";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 257);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 4;
            label10.Text = "Activity Level";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(476, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(576, 364);
            Controls.Add(btnClose);
            Controls.Add(btnKayit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudWidth);
            Controls.Add(nudHeight);
            Controls.Add(cbActivityLevel);
            Controls.Add(cbGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtCity);
            Controls.Add(txtLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtFirstName);
            Controls.Add(txtUserName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmSignupPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SingupPage";
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox textBox2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCity;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbGender;
        private ComboBox cbActivityLevel;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWidth;
        private Label label1;
        private Button btnKayit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private Button btnClose;
    }
}
