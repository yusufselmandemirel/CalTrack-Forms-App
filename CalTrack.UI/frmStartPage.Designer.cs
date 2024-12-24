namespace CalTrack.UI
{
    partial class frmStartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartPage));
            btnLogin = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnSingUp = new Button();
            label3 = new Label();
            label4 = new Label();
            cbxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(696, 368);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(83, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(561, 286);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(218, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(561, 268);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(561, 339);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 23);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(561, 321);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnSingUp
            // 
            btnSingUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSingUp.Location = new Point(696, 397);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(83, 23);
            btnSingUp.TabIndex = 0;
            btnSingUp.Text = "Sign up";
            btnSingUp.UseVisualStyleBackColor = true;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 321);
            label3.Name = "label3";
            label3.Size = new Size(443, 159);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1, -1);
            label4.Name = "label4";
            label4.Size = new Size(153, 46);
            label4.TabIndex = 4;
            label4.Text = "CalTrack";
            // 
            // cbxShowPass
            // 
            cbxShowPass.AutoSize = true;
            cbxShowPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShowPass.Location = new Point(561, 387);
            cbxShowPass.Name = "cbxShowPass";
            cbxShowPass.Size = new Size(112, 19);
            cbxShowPass.TabIndex = 5;
            cbxShowPass.Text = "Show Password";
            cbxShowPass.UseVisualStyleBackColor = true;
            cbxShowPass.CheckedChanged += cbxShowPass_CheckedChanged;
            // 
            // frmStartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(833, 644);
            Controls.Add(cbxShowPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnSingUp);
            Controls.Add(btnLogin);
            Name = "frmStartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalTrack";
            Load += frmStartPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnSingUp;
        private Label label3;
        private Label label4;
        private CheckBox cbxShowPass;
    }
}