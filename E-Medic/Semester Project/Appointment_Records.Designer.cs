namespace Semester_Project
{
    partial class Appointment_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Records));
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.cBSearchBy = new System.Windows.Forms.ComboBox();
            this.DGVAppRec = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPatients = new System.Windows.Forms.Label();
            this.pBPatientRec = new System.Windows.Forms.PictureBox();
            this.lPatientRec = new System.Windows.Forms.Label();
            this.rBTime8 = new System.Windows.Forms.RadioButton();
            this.rBTime6 = new System.Windows.Forms.RadioButton();
            this.rBTime4 = new System.Windows.Forms.RadioButton();
            this.rBTime2 = new System.Windows.Forms.RadioButton();
            this.lTimeSlot = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.lPayStatus = new System.Windows.Forms.Label();
            this.lAppStatus = new System.Windows.Forms.Label();
            this.cBCancelled = new System.Windows.Forms.CheckBox();
            this.cBNotPaid = new System.Windows.Forms.CheckBox();
            this.cBPaid = new System.Windows.Forms.CheckBox();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.lAppLocation = new System.Windows.Forms.Label();
            this.cBAtHome = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPatientRec)).BeginInit();
            this.SuspendLayout();
            // 
            // bUpdate
            // 
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bUpdate.Location = new System.Drawing.Point(459, 500);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 46;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(317, 68);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 45;
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
            "Any",
            "Doctor Name",
            "Patient Name"});
            this.cBSearchBy.Location = new System.Drawing.Point(231, 69);
            this.cBSearchBy.Name = "cBSearchBy";
            this.cBSearchBy.Size = new System.Drawing.Size(80, 21);
            this.cBSearchBy.TabIndex = 44;
            this.cBSearchBy.Text = "Search By....";
            // 
            // DGVAppRec
            // 
            this.DGVAppRec.AllowUserToAddRows = false;
            this.DGVAppRec.AllowUserToDeleteRows = false;
            this.DGVAppRec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVAppRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAppRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9});
            this.DGVAppRec.Location = new System.Drawing.Point(11, 127);
            this.DGVAppRec.Name = "DGVAppRec";
            this.DGVAppRec.ReadOnly = true;
            this.DGVAppRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAppRec.Size = new System.Drawing.Size(525, 225);
            this.DGVAppRec.TabIndex = 43;
            this.DGVAppRec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatients_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Appointment #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doctor Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Speciality";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Appointment Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Time Slot";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Payment";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Appointment Status";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Appointment Place";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // lPatients
            // 
            this.lPatients.AutoSize = true;
            this.lPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lPatients.Location = new System.Drawing.Point(8, 104);
            this.lPatients.Name = "lPatients";
            this.lPatients.Size = new System.Drawing.Size(125, 20);
            this.lPatients.TabIndex = 42;
            this.lPatients.Text = "Appointments:";
            // 
            // pBPatientRec
            // 
            this.pBPatientRec.Image = ((System.Drawing.Image)(resources.GetObject("pBPatientRec.Image")));
            this.pBPatientRec.Location = new System.Drawing.Point(12, 12);
            this.pBPatientRec.Name = "pBPatientRec";
            this.pBPatientRec.Size = new System.Drawing.Size(56, 41);
            this.pBPatientRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPatientRec.TabIndex = 41;
            this.pBPatientRec.TabStop = false;
            // 
            // lPatientRec
            // 
            this.lPatientRec.AutoSize = true;
            this.lPatientRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPatientRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lPatientRec.Location = new System.Drawing.Point(74, 22);
            this.lPatientRec.Name = "lPatientRec";
            this.lPatientRec.Size = new System.Drawing.Size(183, 20);
            this.lPatientRec.TabIndex = 39;
            this.lPatientRec.Text = "Appointment Records";
            // 
            // rBTime8
            // 
            this.rBTime8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBTime8.AutoSize = true;
            this.rBTime8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBTime8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rBTime8.Location = new System.Drawing.Point(265, 403);
            this.rBTime8.Name = "rBTime8";
            this.rBTime8.Size = new System.Drawing.Size(46, 25);
            this.rBTime8.TabIndex = 73;
            this.rBTime8.TabStop = true;
            this.rBTime8.Text = "20:00";
            this.rBTime8.UseVisualStyleBackColor = true;
            this.rBTime8.CheckedChanged += new System.EventHandler(this.rBTime8_CheckedChanged);
            // 
            // rBTime6
            // 
            this.rBTime6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBTime6.AutoSize = true;
            this.rBTime6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBTime6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rBTime6.Location = new System.Drawing.Point(213, 403);
            this.rBTime6.Name = "rBTime6";
            this.rBTime6.Size = new System.Drawing.Size(46, 25);
            this.rBTime6.TabIndex = 72;
            this.rBTime6.TabStop = true;
            this.rBTime6.Text = "18:00";
            this.rBTime6.UseVisualStyleBackColor = true;
            this.rBTime6.CheckedChanged += new System.EventHandler(this.rBTime6_CheckedChanged);
            // 
            // rBTime4
            // 
            this.rBTime4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBTime4.AutoSize = true;
            this.rBTime4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBTime4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rBTime4.Location = new System.Drawing.Point(161, 403);
            this.rBTime4.Name = "rBTime4";
            this.rBTime4.Size = new System.Drawing.Size(46, 25);
            this.rBTime4.TabIndex = 71;
            this.rBTime4.TabStop = true;
            this.rBTime4.Text = "16:00";
            this.rBTime4.UseVisualStyleBackColor = true;
            this.rBTime4.CheckedChanged += new System.EventHandler(this.rBTime4_CheckedChanged);
            // 
            // rBTime2
            // 
            this.rBTime2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBTime2.AutoSize = true;
            this.rBTime2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rBTime2.Location = new System.Drawing.Point(109, 403);
            this.rBTime2.Name = "rBTime2";
            this.rBTime2.Size = new System.Drawing.Size(46, 25);
            this.rBTime2.TabIndex = 70;
            this.rBTime2.TabStop = true;
            this.rBTime2.Text = "14:00";
            this.rBTime2.UseVisualStyleBackColor = true;
            this.rBTime2.CheckedChanged += new System.EventHandler(this.rBTime2_CheckedChanged);
            // 
            // lTimeSlot
            // 
            this.lTimeSlot.AutoSize = true;
            this.lTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lTimeSlot.Location = new System.Drawing.Point(9, 408);
            this.lTimeSlot.Name = "lTimeSlot";
            this.lTimeSlot.Size = new System.Drawing.Size(79, 15);
            this.lTimeSlot.TabIndex = 69;
            this.lTimeSlot.Text = "Time Slots:";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lDate.Location = new System.Drawing.Point(11, 369);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(222, 15);
            this.lDate.TabIndex = 68;
            this.lDate.Text = "Select New Date for Appointment:";
            // 
            // DTPDate
            // 
            this.DTPDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.DTPDate.Location = new System.Drawing.Point(241, 366);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(213, 20);
            this.DTPDate.TabIndex = 67;
            // 
            // lPayStatus
            // 
            this.lPayStatus.AutoSize = true;
            this.lPayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPayStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lPayStatus.Location = new System.Drawing.Point(298, 442);
            this.lPayStatus.Name = "lPayStatus";
            this.lPayStatus.Size = new System.Drawing.Size(110, 15);
            this.lPayStatus.TabIndex = 74;
            this.lPayStatus.Text = "Payment Status:";
            // 
            // lAppStatus
            // 
            this.lAppStatus.AutoSize = true;
            this.lAppStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAppStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAppStatus.Location = new System.Drawing.Point(9, 442);
            this.lAppStatus.Name = "lAppStatus";
            this.lAppStatus.Size = new System.Drawing.Size(135, 15);
            this.lAppStatus.TabIndex = 75;
            this.lAppStatus.Text = "Appointment Status:";
            // 
            // cBCancelled
            // 
            this.cBCancelled.AutoSize = true;
            this.cBCancelled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cBCancelled.Location = new System.Drawing.Point(150, 443);
            this.cBCancelled.Name = "cBCancelled";
            this.cBCancelled.Size = new System.Drawing.Size(73, 17);
            this.cBCancelled.TabIndex = 80;
            this.cBCancelled.Text = "Cancelled";
            this.cBCancelled.UseVisualStyleBackColor = true;
            // 
            // cBNotPaid
            // 
            this.cBNotPaid.AutoSize = true;
            this.cBNotPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cBNotPaid.Location = new System.Drawing.Point(467, 443);
            this.cBNotPaid.Name = "cBNotPaid";
            this.cBNotPaid.Size = new System.Drawing.Size(67, 17);
            this.cBNotPaid.TabIndex = 81;
            this.cBNotPaid.Text = "Not Paid";
            this.cBNotPaid.UseVisualStyleBackColor = true;
            this.cBNotPaid.CheckedChanged += new System.EventHandler(this.cBNotPaid_CheckedChanged);
            // 
            // cBPaid
            // 
            this.cBPaid.AutoSize = true;
            this.cBPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cBPaid.Location = new System.Drawing.Point(414, 443);
            this.cBPaid.Name = "cBPaid";
            this.cBPaid.Size = new System.Drawing.Size(47, 17);
            this.cBPaid.TabIndex = 82;
            this.cBPaid.Text = "Paid";
            this.cBPaid.UseVisualStyleBackColor = true;
            this.cBPaid.CheckedChanged += new System.EventHandler(this.cBPaid_CheckedChanged);
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(12, 72);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(213, 15);
            this.tBSearch.TabIndex = 40;
            this.tBSearch.WaterMark = "Search For Appointments";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // lAppLocation
            // 
            this.lAppLocation.AutoSize = true;
            this.lAppLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAppLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAppLocation.Location = new System.Drawing.Point(8, 476);
            this.lAppLocation.Name = "lAppLocation";
            this.lAppLocation.Size = new System.Drawing.Size(150, 15);
            this.lAppLocation.TabIndex = 83;
            this.lAppLocation.Text = "Appointment Location:";
            // 
            // cBAtHome
            // 
            this.cBAtHome.AutoSize = true;
            this.cBAtHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cBAtHome.Location = new System.Drawing.Point(164, 477);
            this.cBAtHome.Name = "cBAtHome";
            this.cBAtHome.Size = new System.Drawing.Size(67, 17);
            this.cBAtHome.TabIndex = 84;
            this.cBAtHome.Text = "At Home";
            this.cBAtHome.UseVisualStyleBackColor = true;
            // 
            // Appointment_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(547, 535);
            this.Controls.Add(this.cBAtHome);
            this.Controls.Add(this.lAppLocation);
            this.Controls.Add(this.cBPaid);
            this.Controls.Add(this.cBNotPaid);
            this.Controls.Add(this.cBCancelled);
            this.Controls.Add(this.lAppStatus);
            this.Controls.Add(this.lPayStatus);
            this.Controls.Add(this.rBTime8);
            this.Controls.Add(this.rBTime6);
            this.Controls.Add(this.rBTime4);
            this.Controls.Add(this.rBTime2);
            this.Controls.Add(this.lTimeSlot);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBSearchBy);
            this.Controls.Add(this.DGVAppRec);
            this.Controls.Add(this.lPatients);
            this.Controls.Add(this.pBPatientRec);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lPatientRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment_Records";
            this.Text = "Appointment_Records";
            this.Load += new System.EventHandler(this.Appointment_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPatientRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cBSearchBy;
        private System.Windows.Forms.DataGridView DGVAppRec;
        private System.Windows.Forms.Label lPatients;
        private System.Windows.Forms.PictureBox pBPatientRec;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lPatientRec;
        private System.Windows.Forms.RadioButton rBTime8;
        private System.Windows.Forms.RadioButton rBTime6;
        private System.Windows.Forms.RadioButton rBTime4;
        private System.Windows.Forms.RadioButton rBTime2;
        private System.Windows.Forms.Label lTimeSlot;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label lPayStatus;
        private System.Windows.Forms.Label lAppStatus;
        private System.Windows.Forms.CheckBox cBCancelled;
        private System.Windows.Forms.CheckBox cBNotPaid;
        private System.Windows.Forms.CheckBox cBPaid;
        private System.Windows.Forms.Label lAppLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.CheckBox cBAtHome;
    }
}