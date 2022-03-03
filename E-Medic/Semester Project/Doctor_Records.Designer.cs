namespace Semester_Project
{
    partial class Doctor_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Records));
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.cBSearchBy = new System.Windows.Forms.ComboBox();
            this.DGVDoctors = new System.Windows.Forms.DataGridView();
            this.lAvailDocs = new System.Windows.Forms.Label();
            this.pBDoctor = new System.Windows.Forms.PictureBox();
            this.lDocRec = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.rBNo = new System.Windows.Forms.RadioButton();
            this.rBYes = new System.Windows.Forms.RadioButton();
            this.lHomeDoc = new System.Windows.Forms.Label();
            this.lDocName = new System.Windows.Forms.Label();
            this.lSpecialty = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.tBSpecialty = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBSalary = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.DGVdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoctor)).BeginInit();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDelete
            // 
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bDelete.Location = new System.Drawing.Point(447, 104);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 49;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bUpdate.Location = new System.Drawing.Point(363, 104);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 48;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(375, 73);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 47;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cBSearchBy
            // 
            this.cBSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBSearchBy.FormattingEnabled = true;
            this.cBSearchBy.Items.AddRange(new object[] {
            "Name",
            "Speciality",
            "Salary"});
            this.cBSearchBy.Location = new System.Drawing.Point(273, 73);
            this.cBSearchBy.Name = "cBSearchBy";
            this.cBSearchBy.Size = new System.Drawing.Size(96, 21);
            this.cBSearchBy.TabIndex = 46;
            this.cBSearchBy.Text = "Search By....";
            this.cBSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBSearchBy_KeyPress);
            // 
            // DGVDoctors
            // 
            this.DGVDoctors.AllowUserToAddRows = false;
            this.DGVDoctors.AllowUserToDeleteRows = false;
            this.DGVDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVdID,
            this.DGVName,
            this.DGVSpeciality,
            this.DGVHome,
            this.DGVFee});
            this.DGVDoctors.Location = new System.Drawing.Point(12, 131);
            this.DGVDoctors.Name = "DGVDoctors";
            this.DGVDoctors.ReadOnly = true;
            this.DGVDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoctors.Size = new System.Drawing.Size(541, 211);
            this.DGVDoctors.TabIndex = 45;
            this.DGVDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDoctors_CellClick);
            // 
            // lAvailDocs
            // 
            this.lAvailDocs.AutoSize = true;
            this.lAvailDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvailDocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAvailDocs.Location = new System.Drawing.Point(8, 108);
            this.lAvailDocs.Name = "lAvailDocs";
            this.lAvailDocs.Size = new System.Drawing.Size(77, 20);
            this.lAvailDocs.TabIndex = 44;
            this.lAvailDocs.Text = "Doctors:";
            // 
            // pBDoctor
            // 
            this.pBDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pBDoctor.Image")));
            this.pBDoctor.Location = new System.Drawing.Point(12, 12);
            this.pBDoctor.Name = "pBDoctor";
            this.pBDoctor.Size = new System.Drawing.Size(56, 41);
            this.pBDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDoctor.TabIndex = 43;
            this.pBDoctor.TabStop = false;
            // 
            // lDocRec
            // 
            this.lDocRec.AutoSize = true;
            this.lDocRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDocRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lDocRec.Location = new System.Drawing.Point(74, 24);
            this.lDocRec.Name = "lDocRec";
            this.lDocRec.Size = new System.Drawing.Size(135, 20);
            this.lDocRec.TabIndex = 41;
            this.lDocRec.Text = "Doctor Records";
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pInfo.Controls.Add(this.bDelete);
            this.pInfo.Controls.Add(this.rBNo);
            this.pInfo.Controls.Add(this.bUpdate);
            this.pInfo.Controls.Add(this.rBYes);
            this.pInfo.Controls.Add(this.lHomeDoc);
            this.pInfo.Controls.Add(this.lDocName);
            this.pInfo.Controls.Add(this.lSpecialty);
            this.pInfo.Controls.Add(this.lSalary);
            this.pInfo.Controls.Add(this.tBSpecialty);
            this.pInfo.Controls.Add(this.tBSalary);
            this.pInfo.Controls.Add(this.tBName);
            this.pInfo.Location = new System.Drawing.Point(12, 348);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(541, 142);
            this.pInfo.TabIndex = 39;
            // 
            // rBNo
            // 
            this.rBNo.AutoSize = true;
            this.rBNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rBNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBNo.Location = new System.Drawing.Point(179, 76);
            this.rBNo.Name = "rBNo";
            this.rBNo.Size = new System.Drawing.Size(39, 17);
            this.rBNo.TabIndex = 69;
            this.rBNo.TabStop = true;
            this.rBNo.Text = "No";
            this.rBNo.UseVisualStyleBackColor = false;
            // 
            // rBYes
            // 
            this.rBYes.AutoSize = true;
            this.rBYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rBYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBYes.Location = new System.Drawing.Point(122, 76);
            this.rBYes.Name = "rBYes";
            this.rBYes.Size = new System.Drawing.Size(43, 17);
            this.rBYes.TabIndex = 68;
            this.rBYes.TabStop = true;
            this.rBYes.Text = "Yes";
            this.rBYes.UseVisualStyleBackColor = false;
            // 
            // lHomeDoc
            // 
            this.lHomeDoc.AutoSize = true;
            this.lHomeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomeDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lHomeDoc.Location = new System.Drawing.Point(21, 76);
            this.lHomeDoc.Name = "lHomeDoc";
            this.lHomeDoc.Size = new System.Drawing.Size(95, 15);
            this.lHomeDoc.TabIndex = 67;
            this.lHomeDoc.Text = "Home Doctor:";
            // 
            // lDocName
            // 
            this.lDocName.AutoSize = true;
            this.lDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lDocName.Location = new System.Drawing.Point(63, 12);
            this.lDocName.Name = "lDocName";
            this.lDocName.Size = new System.Drawing.Size(49, 15);
            this.lDocName.TabIndex = 66;
            this.lDocName.Text = "Name:";
            // 
            // lSpecialty
            // 
            this.lSpecialty.AutoSize = true;
            this.lSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lSpecialty.Location = new System.Drawing.Point(43, 34);
            this.lSpecialty.Name = "lSpecialty";
            this.lSpecialty.Size = new System.Drawing.Size(69, 15);
            this.lSpecialty.TabIndex = 65;
            this.lSpecialty.Text = "Specialty:";
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lSalary.Location = new System.Drawing.Point(77, 55);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(35, 15);
            this.lSalary.TabIndex = 64;
            this.lSalary.Text = "Fee:";
            // 
            // tBSpecialty
            // 
            this.tBSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSpecialty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSpecialty.Location = new System.Drawing.Point(122, 34);
            this.tBSpecialty.Name = "tBSpecialty";
            this.tBSpecialty.Size = new System.Drawing.Size(213, 15);
            this.tBSpecialty.TabIndex = 22;
            this.tBSpecialty.WaterMark = "Specialty";
            this.tBSpecialty.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSpecialty.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSpecialty.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBSalary
            // 
            this.tBSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSalary.Location = new System.Drawing.Point(122, 55);
            this.tBSalary.Name = "tBSalary";
            this.tBSalary.Size = new System.Drawing.Size(103, 15);
            this.tBSalary.TabIndex = 21;
            this.tBSalary.WaterMark = "Fee";
            this.tBSalary.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSalary.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSalary.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBName.Location = new System.Drawing.Point(122, 10);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(170, 18);
            this.tBName.TabIndex = 0;
            this.tBName.WaterMark = "Doctor Name";
            this.tBName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(12, 76);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(246, 15);
            this.tBSearch.TabIndex = 42;
            this.tBSearch.WaterMark = "Search For Doctors...";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // DGVdID
            // 
            this.DGVdID.HeaderText = "dID";
            this.DGVdID.Name = "DGVdID";
            this.DGVdID.ReadOnly = true;
            this.DGVdID.Visible = false;
            // 
            // DGVName
            // 
            this.DGVName.HeaderText = "Doctor Name";
            this.DGVName.Name = "DGVName";
            this.DGVName.ReadOnly = true;
            this.DGVName.Width = 125;
            // 
            // DGVSpeciality
            // 
            this.DGVSpeciality.HeaderText = "Speciality";
            this.DGVSpeciality.Name = "DGVSpeciality";
            this.DGVSpeciality.ReadOnly = true;
            this.DGVSpeciality.Width = 125;
            // 
            // DGVHome
            // 
            this.DGVHome.HeaderText = "Home Doctor";
            this.DGVHome.Name = "DGVHome";
            this.DGVHome.ReadOnly = true;
            this.DGVHome.Width = 120;
            // 
            // DGVFee
            // 
            this.DGVFee.HeaderText = "Fee";
            this.DGVFee.Name = "DGVFee";
            this.DGVFee.ReadOnly = true;
            this.DGVFee.Width = 125;
            // 
            // Doctor_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(565, 502);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBSearchBy);
            this.Controls.Add(this.DGVDoctors);
            this.Controls.Add(this.lAvailDocs);
            this.Controls.Add(this.pBDoctor);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lDocRec);
            this.Controls.Add(this.pInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor_Records";
            this.Text = "Doctor_Records";
            this.Load += new System.EventHandler(this.Doctor_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoctor)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cBSearchBy;
        private System.Windows.Forms.DataGridView DGVDoctors;
        private System.Windows.Forms.Label lAvailDocs;
        private System.Windows.Forms.PictureBox pBDoctor;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lDocRec;
        private System.Windows.Forms.Panel pInfo;
        private ChreneLib.Controls.TextBoxes.CTextBox tBName;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSpecialty;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSalary;
        private System.Windows.Forms.Label lHomeDoc;
        private System.Windows.Forms.Label lDocName;
        private System.Windows.Forms.Label lSpecialty;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.RadioButton rBNo;
        private System.Windows.Forms.RadioButton rBYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVFee;
    }
}