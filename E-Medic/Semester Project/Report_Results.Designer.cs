namespace Semester_Project
{
    partial class Report_Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Results));
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.cBSearchTest = new System.Windows.Forms.ComboBox();
            this.DGVReports = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVRepResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lReports = new System.Windows.Forms.Label();
            this.pBReport = new System.Windows.Forms.PictureBox();
            this.lReportRec = new System.Windows.Forms.Label();
            this.pDetails = new System.Windows.Forms.Panel();
            this.cBRepResult = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lRepResult = new System.Windows.Forms.Label();
            this.lRepName = new System.Windows.Forms.Label();
            this.rBNotPaid = new System.Windows.Forms.RadioButton();
            this.rBPaid = new System.Windows.Forms.RadioButton();
            this.tBRepName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBReport)).BeginInit();
            this.pDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDelete
            // 
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bDelete.Location = new System.Drawing.Point(380, 119);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 59;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bUpdate.Location = new System.Drawing.Point(299, 119);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 58;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(389, 73);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 57;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cBSearchTest
            // 
            this.cBSearchTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBSearchTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSearchTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBSearchTest.FormattingEnabled = true;
            this.cBSearchTest.Items.AddRange(new object[] {
            "Any",
            "Malaria",
            "Hepatitis",
            "Corona",
            "HIV",
            "Diabetes",
            "Lung Cancer"});
            this.cBSearchTest.Location = new System.Drawing.Point(262, 74);
            this.cBSearchTest.Name = "cBSearchTest";
            this.cBSearchTest.Size = new System.Drawing.Size(110, 21);
            this.cBSearchTest.TabIndex = 56;
            this.cBSearchTest.Text = "Search Test By...";
            this.cBSearchTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBSearchTest_KeyPress);
            // 
            // DGVReports
            // 
            this.DGVReports.AllowUserToAddRows = false;
            this.DGVReports.AllowUserToDeleteRows = false;
            this.DGVReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.DGVPName,
            this.DGVTestName,
            this.DGVRepResult,
            this.DGVPayStatus});
            this.DGVReports.Location = new System.Drawing.Point(9, 130);
            this.DGVReports.MultiSelect = false;
            this.DGVReports.Name = "DGVReports";
            this.DGVReports.ReadOnly = true;
            this.DGVReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReports.Size = new System.Drawing.Size(484, 242);
            this.DGVReports.TabIndex = 55;
            this.DGVReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVReports_CellClick);
            this.DGVReports.VisibleChanged += new System.EventHandler(this.DGVReports_VisibleChanged);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Test_ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // DGVPName
            // 
            this.DGVPName.HeaderText = "Patient Name";
            this.DGVPName.Name = "DGVPName";
            this.DGVPName.ReadOnly = true;
            this.DGVPName.Width = 110;
            // 
            // DGVTestName
            // 
            this.DGVTestName.HeaderText = "Test Name";
            this.DGVTestName.Name = "DGVTestName";
            this.DGVTestName.ReadOnly = true;
            this.DGVTestName.Width = 110;
            // 
            // DGVRepResult
            // 
            this.DGVRepResult.HeaderText = "Report Result";
            this.DGVRepResult.Name = "DGVRepResult";
            this.DGVRepResult.ReadOnly = true;
            this.DGVRepResult.Width = 110;
            // 
            // DGVPayStatus
            // 
            this.DGVPayStatus.HeaderText = "Payment Status";
            this.DGVPayStatus.Name = "DGVPayStatus";
            this.DGVPayStatus.ReadOnly = true;
            this.DGVPayStatus.Width = 110;
            // 
            // lReports
            // 
            this.lReports.AutoSize = true;
            this.lReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lReports.Location = new System.Drawing.Point(5, 107);
            this.lReports.Name = "lReports";
            this.lReports.Size = new System.Drawing.Size(78, 20);
            this.lReports.TabIndex = 54;
            this.lReports.Text = "Reports:";
            // 
            // pBReport
            // 
            this.pBReport.Image = ((System.Drawing.Image)(resources.GetObject("pBReport.Image")));
            this.pBReport.Location = new System.Drawing.Point(6, 12);
            this.pBReport.Name = "pBReport";
            this.pBReport.Size = new System.Drawing.Size(56, 41);
            this.pBReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBReport.TabIndex = 53;
            this.pBReport.TabStop = false;
            // 
            // lReportRec
            // 
            this.lReportRec.AutoSize = true;
            this.lReportRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReportRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lReportRec.Location = new System.Drawing.Point(68, 22);
            this.lReportRec.Name = "lReportRec";
            this.lReportRec.Size = new System.Drawing.Size(136, 20);
            this.lReportRec.TabIndex = 51;
            this.lReportRec.Text = "Report Records";
            // 
            // pDetails
            // 
            this.pDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pDetails.Controls.Add(this.cBRepResult);
            this.pDetails.Controls.Add(this.label2);
            this.pDetails.Controls.Add(this.lRepResult);
            this.pDetails.Controls.Add(this.lRepName);
            this.pDetails.Controls.Add(this.bDelete);
            this.pDetails.Controls.Add(this.rBNotPaid);
            this.pDetails.Controls.Add(this.bUpdate);
            this.pDetails.Controls.Add(this.rBPaid);
            this.pDetails.Controls.Add(this.tBRepName);
            this.pDetails.Location = new System.Drawing.Point(9, 378);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(484, 154);
            this.pDetails.TabIndex = 50;
            // 
            // cBRepResult
            // 
            this.cBRepResult.FormattingEnabled = true;
            this.cBRepResult.Items.AddRange(new object[] {
            "Pending",
            "Positive",
            "Negative"});
            this.cBRepResult.Location = new System.Drawing.Point(114, 46);
            this.cBRepResult.Name = "cBRepResult";
            this.cBRepResult.Size = new System.Drawing.Size(170, 21);
            this.cBRepResult.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Report Payment:";
            // 
            // lRepResult
            // 
            this.lRepResult.AutoSize = true;
            this.lRepResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lRepResult.Location = new System.Drawing.Point(12, 49);
            this.lRepResult.Name = "lRepResult";
            this.lRepResult.Size = new System.Drawing.Size(99, 15);
            this.lRepResult.TabIndex = 64;
            this.lRepResult.Text = "Report Result:";
            // 
            // lRepName
            // 
            this.lRepName.AutoSize = true;
            this.lRepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lRepName.Location = new System.Drawing.Point(12, 14);
            this.lRepName.Name = "lRepName";
            this.lRepName.Size = new System.Drawing.Size(96, 15);
            this.lRepName.TabIndex = 63;
            this.lRepName.Text = "Report Name:";
            // 
            // rBNotPaid
            // 
            this.rBNotPaid.AutoSize = true;
            this.rBNotPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rBNotPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBNotPaid.Location = new System.Drawing.Point(218, 82);
            this.rBNotPaid.Name = "rBNotPaid";
            this.rBNotPaid.Size = new System.Drawing.Size(66, 17);
            this.rBNotPaid.TabIndex = 23;
            this.rBNotPaid.TabStop = true;
            this.rBNotPaid.Text = "Not Paid";
            this.rBNotPaid.UseVisualStyleBackColor = false;
            // 
            // rBPaid
            // 
            this.rBPaid.AutoSize = true;
            this.rBPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rBPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBPaid.Location = new System.Drawing.Point(131, 82);
            this.rBPaid.Name = "rBPaid";
            this.rBPaid.Size = new System.Drawing.Size(46, 17);
            this.rBPaid.TabIndex = 22;
            this.rBPaid.TabStop = true;
            this.rBPaid.Text = "Paid";
            this.rBPaid.UseVisualStyleBackColor = false;
            // 
            // tBRepName
            // 
            this.tBRepName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBRepName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBRepName.Enabled = false;
            this.tBRepName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBRepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBRepName.Location = new System.Drawing.Point(114, 12);
            this.tBRepName.Name = "tBRepName";
            this.tBRepName.Size = new System.Drawing.Size(170, 18);
            this.tBRepName.TabIndex = 0;
            this.tBRepName.WaterMark = "Report Name";
            this.tBRepName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBRepName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBRepName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(12, 77);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(213, 15);
            this.tBSearch.TabIndex = 52;
            this.tBSearch.WaterMark = "Enter Patient Cnic";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Report_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(502, 544);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBSearchTest);
            this.Controls.Add(this.DGVReports);
            this.Controls.Add(this.lReports);
            this.Controls.Add(this.pBReport);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lReportRec);
            this.Controls.Add(this.pDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Results";
            this.Load += new System.EventHandler(this.Report_Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBReport)).EndInit();
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cBSearchTest;
        private System.Windows.Forms.DataGridView DGVReports;
        private System.Windows.Forms.Label lReports;
        private System.Windows.Forms.PictureBox pBReport;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lReportRec;
        private System.Windows.Forms.Panel pDetails;
        private ChreneLib.Controls.TextBoxes.CTextBox tBRepName;
        private System.Windows.Forms.RadioButton rBNotPaid;
        private System.Windows.Forms.RadioButton rBPaid;
        private System.Windows.Forms.Label lRepResult;
        private System.Windows.Forms.Label lRepName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBRepResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVRepResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPayStatus;
    }
}