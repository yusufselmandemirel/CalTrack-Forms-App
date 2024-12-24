namespace CalTrack.UI
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            dgvReport = new DataGridView();
            cmbReportType = new ComboBox();
            label1 = new Label();
            nudDailyCalorie = new NumericUpDown();
            labelCalorie = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnReportByDate = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDailyCalorie).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReport.BackgroundColor = Color.SandyBrown;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(11, 221);
            dgvReport.Name = "dgvReport";
            dgvReport.RowTemplate.Height = 25;
            dgvReport.Size = new Size(891, 274);
            dgvReport.TabIndex = 0;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(12, 125);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(121, 23);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 95);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Choose Report Type";
            // 
            // nudDailyCalorie
            // 
            nudDailyCalorie.Enabled = false;
            nudDailyCalorie.Location = new Point(13, 181);
            nudDailyCalorie.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            nudDailyCalorie.Name = "nudDailyCalorie";
            nudDailyCalorie.Size = new Size(120, 23);
            nudDailyCalorie.TabIndex = 3;
            nudDailyCalorie.Visible = false;
            // 
            // labelCalorie
            // 
            labelCalorie.AutoSize = true;
            labelCalorie.Location = new Point(11, 163);
            labelCalorie.Name = "labelCalorie";
            labelCalorie.Size = new Size(119, 15);
            labelCalorie.TabIndex = 4;
            labelCalorie.Text = "Daily Calories Taken:";
            labelCalorie.Visible = false;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(400, 87);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 5;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(606, 87);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 69);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(606, 69);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "End Date";
            // 
            // btnReportByDate
            // 
            btnReportByDate.BackColor = Color.ForestGreen;
            btnReportByDate.Location = new Point(532, 125);
            btnReportByDate.Name = "btnReportByDate";
            btnReportByDate.Size = new Size(147, 53);
            btnReportByDate.TabIndex = 8;
            btnReportByDate.Text = "Report By Date";
            btnReportByDate.UseVisualStyleBackColor = false;
            btnReportByDate.Click += btnReportByDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(449, 36);
            label4.Name = "label4";
            label4.Size = new Size(323, 20);
            label4.TabIndex = 9;
            label4.Text = "Choose the dates of the report you want to see ";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 521);
            Controls.Add(label4);
            Controls.Add(btnReportByDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(labelCalorie);
            Controls.Add(nudDailyCalorie);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Controls.Add(dgvReport);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Page";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDailyCalorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReport;
        private ComboBox cmbReportType;
        private Label label1;
        private NumericUpDown nudDailyCalorie;
        private Label labelCalorie;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private Label label3;
        private Button btnReportByDate;
        private Label label4;
    }
}