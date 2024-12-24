namespace CalTrack.UI
{
    partial class frmUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUser));
            btnClose = new Button();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbGender = new ComboBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            txtFirstName = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(553, 39);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 30);
            btnClose.TabIndex = 25;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 134);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 20;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 78);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 19;
            label6.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 186);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 18;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 128);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 24;
            label1.Text = "First Name";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(136, 204);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 23);
            cbGender.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(136, 146);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(379, 152);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(136, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(379, 96);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 23);
            txtUserName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(553, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 33);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(695, 421);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGender);
            Controls.Add(txtLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtFirstName);
            Controls.Add(txtUserName);
            Name = "frmUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbGender;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtFirstName;
        private TextBox txtUserName;
        private Button btnSave;
    }
}