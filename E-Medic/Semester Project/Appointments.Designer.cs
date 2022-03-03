namespace Semester_Project
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.pAppointment = new System.Windows.Forms.Panel();
            this.lAppType = new System.Windows.Forms.Label();
            this.cBAtHome = new System.Windows.Forms.CheckBox();
            this.cBAvailNo = new System.Windows.Forms.CheckBox();
            this.cBAvailYes = new System.Windows.Forms.CheckBox();
            this.lAvailable = new System.Windows.Forms.Label();
            this.lSpeciality = new System.Windows.Forms.Label();
            this.rBTime8 = new System.Windows.Forms.RadioButton();
            this.rBTime6 = new System.Windows.Forms.RadioButton();
            this.rBTime4 = new System.Windows.Forms.RadioButton();
            this.rBTime2 = new System.Windows.Forms.RadioButton();
            this.lTime = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bFilter = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.pBSearch = new System.Windows.Forms.PictureBox();
            this.bBook = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.DGVDoctors = new System.Windows.Forms.DataGridView();
            this.lAvailDocs = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cBCardiologist = new System.Windows.Forms.CheckBox();
            this.cBPsychiatric = new System.Windows.Forms.CheckBox();
            this.cBPediatric = new System.Windows.Forms.CheckBox();
            this.cBNeuro = new System.Windows.Forms.CheckBox();
            this.cBNephro = new System.Windows.Forms.CheckBox();
            this.lFilters = new System.Windows.Forms.Label();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.lAppointments = new System.Windows.Forms.Label();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pAppointment
            // 
            this.pAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pAppointment.Controls.Add(this.lAppType);
            this.pAppointment.Controls.Add(this.cBAtHome);
            this.pAppointment.Controls.Add(this.cBAvailNo);
            this.pAppointment.Controls.Add(this.cBAvailYes);
            this.pAppointment.Controls.Add(this.lAvailable);
            this.pAppointment.Controls.Add(this.lSpeciality);
            this.pAppointment.Controls.Add(this.rBTime8);
            this.pAppointment.Controls.Add(this.rBTime6);
            this.pAppointment.Controls.Add(this.rBTime4);
            this.pAppointment.Controls.Add(this.rBTime2);
            this.pAppointment.Controls.Add(this.lTime);
            this.pAppointment.Controls.Add(this.bReset);
            this.pAppointment.Controls.Add(this.bFilter);
            this.pAppointment.Controls.Add(this.bSearch);
            this.pAppointment.Controls.Add(this.pBSearch);
            this.pAppointment.Controls.Add(this.bBook);
            this.pAppointment.Controls.Add(this.lDate);
            this.pAppointment.Controls.Add(this.DTPDate);
            this.pAppointment.Controls.Add(this.DGVDoctors);
            this.pAppointment.Controls.Add(this.lAvailDocs);
            this.pAppointment.Controls.Add(this.pictureBox2);
            this.pAppointment.Controls.Add(this.cBCardiologist);
            this.pAppointment.Controls.Add(this.cBPsychiatric);
            this.pAppointment.Controls.Add(this.cBPediatric);
            this.pAppointment.Controls.Add(this.cBNeuro);
            this.pAppointment.Controls.Add(this.cBNephro);
            this.pAppointment.Controls.Add(this.lFilters);
            this.pAppointment.Controls.Add(this.tBSearch);
            this.pAppointment.Controls.Add(this.lAppointments);
            this.pAppointment.Location = new System.Drawing.Point(1, 0);
            this.pAppointment.Name = "pAppointment";
            this.pAppointment.Size = new System.Drawing.Size(645, 528);
            this.pAppointment.TabIndex = 0;
            // 
            // lAppType
            // 
            this.lAppType.AutoSize = true;
            this.lAppType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAppType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAppType.Location = new System.Drawing.Point(28, 442);
            this.lAppType.Name = "lAppType";
            this.lAppType.Size = new System.Drawing.Size(125, 15);
            this.lAppType.TabIndex = 72;
            this.lAppType.Text = "Appointment Type:";
            // 
            // cBAtHome
            // 
            this.cBAtHome.AutoSize = true;
            this.cBAtHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBAtHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBAtHome.Location = new System.Drawing.Point(166, 443);
            this.cBAtHome.Name = "cBAtHome";
            this.cBAtHome.Size = new System.Drawing.Size(67, 17);
            this.cBAtHome.TabIndex = 71;
            this.cBAtHome.Text = "At Home";
            this.cBAtHome.UseVisualStyleBackColor = false;
            // 
            // cBAvailNo
            // 
            this.cBAvailNo.AutoSize = true;
            this.cBAvailNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBAvailNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBAvailNo.Location = new System.Drawing.Point(246, 109);
            this.cBAvailNo.Name = "cBAvailNo";
            this.cBAvailNo.Size = new System.Drawing.Size(40, 17);
            this.cBAvailNo.TabIndex = 70;
            this.cBAvailNo.Text = "No";
            this.cBAvailNo.UseVisualStyleBackColor = false;
            this.cBAvailNo.CheckedChanged += new System.EventHandler(this.cBAvailNo_CheckedChanged);
            // 
            // cBAvailYes
            // 
            this.cBAvailYes.AutoSize = true;
            this.cBAvailYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBAvailYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBAvailYes.Location = new System.Drawing.Point(192, 109);
            this.cBAvailYes.Name = "cBAvailYes";
            this.cBAvailYes.Size = new System.Drawing.Size(44, 17);
            this.cBAvailYes.TabIndex = 69;
            this.cBAvailYes.Text = "Yes";
            this.cBAvailYes.UseVisualStyleBackColor = false;
            this.cBAvailYes.CheckedChanged += new System.EventHandler(this.cBAvailYes_CheckedChanged);
            // 
            // lAvailable
            // 
            this.lAvailable.AutoSize = true;
            this.lAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lAvailable.Location = new System.Drawing.Point(25, 108);
            this.lAvailable.Name = "lAvailable";
            this.lAvailable.Size = new System.Drawing.Size(154, 16);
            this.lAvailable.TabIndex = 68;
            this.lAvailable.Text = "Available For Home :";
            // 
            // lSpeciality
            // 
            this.lSpeciality.AutoSize = true;
            this.lSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSpeciality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lSpeciality.Location = new System.Drawing.Point(23, 80);
            this.lSpeciality.Name = "lSpeciality";
            this.lSpeciality.Size = new System.Drawing.Size(85, 16);
            this.lSpeciality.TabIndex = 67;
            this.lSpeciality.Text = "Speciality :";
            // 
            // rBTime8
            // 
            this.rBTime8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBTime8.AutoSize = true;
            this.rBTime8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBTime8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBTime8.Location = new System.Drawing.Point(327, 397);
            this.rBTime8.Name = "rBTime8";
            this.rBTime8.Size = new System.Drawing.Size(46, 25);
            this.rBTime8.TabIndex = 66;
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
            this.rBTime6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBTime6.Location = new System.Drawing.Point(264, 397);
            this.rBTime6.Name = "rBTime6";
            this.rBTime6.Size = new System.Drawing.Size(46, 25);
            this.rBTime6.TabIndex = 65;
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
            this.rBTime4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBTime4.Location = new System.Drawing.Point(200, 397);
            this.rBTime4.Name = "rBTime4";
            this.rBTime4.Size = new System.Drawing.Size(46, 25);
            this.rBTime4.TabIndex = 64;
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
            this.rBTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rBTime2.Location = new System.Drawing.Point(135, 397);
            this.rBTime2.Name = "rBTime2";
            this.rBTime2.Size = new System.Drawing.Size(46, 25);
            this.rBTime2.TabIndex = 63;
            this.rBTime2.TabStop = true;
            this.rBTime2.Text = "14:00";
            this.rBTime2.UseVisualStyleBackColor = true;
            this.rBTime2.CheckedChanged += new System.EventHandler(this.rBTime2_CheckedChanged);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lTime.Location = new System.Drawing.Point(28, 401);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(79, 15);
            this.lTime.TabIndex = 62;
            this.lTime.Text = "Time Slots:";
            // 
            // bReset
            // 
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bReset.Location = new System.Drawing.Point(521, 353);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 61;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bFilter
            // 
            this.bFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bFilter.Location = new System.Drawing.Point(521, 135);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(75, 23);
            this.bFilter.TabIndex = 60;
            this.bFilter.Text = "Filter";
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(530, 10);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 59;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pBSearch
            // 
            this.pBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pBSearch.Image = ((System.Drawing.Image)(resources.GetObject("pBSearch.Image")));
            this.pBSearch.Location = new System.Drawing.Point(273, 12);
            this.pBSearch.Name = "pBSearch";
            this.pBSearch.Size = new System.Drawing.Size(22, 20);
            this.pBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSearch.TabIndex = 23;
            this.pBSearch.TabStop = false;
            // 
            // bBook
            // 
            this.bBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bBook.Image = ((System.Drawing.Image)(resources.GetObject("bBook.Image")));
            this.bBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBook.Location = new System.Drawing.Point(274, 481);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(90, 37);
            this.bBook.TabIndex = 22;
            this.bBook.Text = "Book";
            this.bBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBook.UseVisualStyleBackColor = true;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lDate.Location = new System.Drawing.Point(24, 361);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(190, 15);
            this.lDate.TabIndex = 21;
            this.lDate.Text = "Select Date for Appointment:";
            // 
            // DTPDate
            // 
            this.DTPDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.DTPDate.CustomFormat = "ddddd,dMMMMyyyy                hhtt";
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(220, 361);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(213, 20);
            this.DTPDate.TabIndex = 20;
            this.DTPDate.Value = new System.DateTime(2021, 6, 3, 0, 51, 24, 0);
            // 
            // DGVDoctors
            // 
            this.DGVDoctors.AllowUserToAddRows = false;
            this.DGVDoctors.AllowUserToDeleteRows = false;
            this.DGVDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.DocName,
            this.DocSpecialty,
            this.AvailHome,
            this.DocFees});
            this.DGVDoctors.Location = new System.Drawing.Point(24, 164);
            this.DGVDoctors.Name = "DGVDoctors";
            this.DGVDoctors.ReadOnly = true;
            this.DGVDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoctors.Size = new System.Drawing.Size(571, 185);
            this.DGVDoctors.TabIndex = 15;
            // 
            // lAvailDocs
            // 
            this.lAvailDocs.AutoSize = true;
            this.lAvailDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvailDocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAvailDocs.Location = new System.Drawing.Point(23, 135);
            this.lAvailDocs.Name = "lAvailDocs";
            this.lAvailDocs.Size = new System.Drawing.Size(154, 20);
            this.lAvailDocs.TabIndex = 14;
            this.lAvailDocs.Text = "Available Doctors:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // cBCardiologist
            // 
            this.cBCardiologist.AutoSize = true;
            this.cBCardiologist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBCardiologist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBCardiologist.Location = new System.Drawing.Point(525, 81);
            this.cBCardiologist.Name = "cBCardiologist";
            this.cBCardiologist.Size = new System.Drawing.Size(80, 17);
            this.cBCardiologist.TabIndex = 12;
            this.cBCardiologist.Text = "Cardiologist";
            this.cBCardiologist.UseVisualStyleBackColor = false;
            // 
            // cBPsychiatric
            // 
            this.cBPsychiatric.AutoSize = true;
            this.cBPsychiatric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBPsychiatric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBPsychiatric.Location = new System.Drawing.Point(419, 81);
            this.cBPsychiatric.Name = "cBPsychiatric";
            this.cBPsychiatric.Size = new System.Drawing.Size(77, 17);
            this.cBPsychiatric.TabIndex = 11;
            this.cBPsychiatric.Text = "Psychiatric";
            this.cBPsychiatric.UseVisualStyleBackColor = false;
            // 
            // cBPediatric
            // 
            this.cBPediatric.AutoSize = true;
            this.cBPediatric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBPediatric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBPediatric.Location = new System.Drawing.Point(329, 81);
            this.cBPediatric.Name = "cBPediatric";
            this.cBPediatric.Size = new System.Drawing.Size(67, 17);
            this.cBPediatric.TabIndex = 10;
            this.cBPediatric.Text = "Pediatric";
            this.cBPediatric.UseVisualStyleBackColor = false;
            // 
            // cBNeuro
            // 
            this.cBNeuro.AutoSize = true;
            this.cBNeuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBNeuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBNeuro.Location = new System.Drawing.Point(231, 81);
            this.cBNeuro.Name = "cBNeuro";
            this.cBNeuro.Size = new System.Drawing.Size(79, 17);
            this.cBNeuro.TabIndex = 9;
            this.cBNeuro.Text = "Neurologist";
            this.cBNeuro.UseVisualStyleBackColor = false;
            // 
            // cBNephro
            // 
            this.cBNephro.AutoSize = true;
            this.cBNephro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cBNephro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBNephro.Location = new System.Drawing.Point(121, 81);
            this.cBNephro.Name = "cBNephro";
            this.cBNephro.Size = new System.Drawing.Size(85, 17);
            this.cBNephro.TabIndex = 8;
            this.cBNephro.Text = "Nephrologist";
            this.cBNephro.UseVisualStyleBackColor = false;
            // 
            // lFilters
            // 
            this.lFilters.AutoSize = true;
            this.lFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lFilters.Location = new System.Drawing.Point(270, 50);
            this.lFilters.Name = "lFilters";
            this.lFilters.Size = new System.Drawing.Size(67, 24);
            this.lFilters.TabIndex = 7;
            this.lFilters.Text = "Filters";
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(301, 15);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(213, 15);
            this.tBSearch.TabIndex = 5;
            this.tBSearch.WaterMark = "Search for Doctors....";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // lAppointments
            // 
            this.lAppointments.AutoSize = true;
            this.lAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAppointments.Location = new System.Drawing.Point(88, 10);
            this.lAppointments.Name = "lAppointments";
            this.lAppointments.Size = new System.Drawing.Size(120, 20);
            this.lAppointments.TabIndex = 4;
            this.lAppointments.Text = "Appointments";
            // 
            // dID
            // 
            this.dID.HeaderText = "ID";
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            this.dID.Visible = false;
            // 
            // DocName
            // 
            this.DocName.HeaderText = "Name";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            this.DocName.Width = 137;
            // 
            // DocSpecialty
            // 
            this.DocSpecialty.HeaderText = "Specialty";
            this.DocSpecialty.Name = "DocSpecialty";
            this.DocSpecialty.ReadOnly = true;
            this.DocSpecialty.Width = 130;
            // 
            // AvailHome
            // 
            this.AvailHome.HeaderText = "Available for Home Visits";
            this.AvailHome.Name = "AvailHome";
            this.AvailHome.ReadOnly = true;
            this.AvailHome.Width = 130;
            // 
            // DocFees
            // 
            this.DocFees.HeaderText = "Fee";
            this.DocFees.Name = "DocFees";
            this.DocFees.ReadOnly = true;
            this.DocFees.Width = 130;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.pAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Appointments_Load);
            this.pAppointment.ResumeLayout(false);
            this.pAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAppointment;
        private System.Windows.Forms.CheckBox cBCardiologist;
        private System.Windows.Forms.CheckBox cBPsychiatric;
        private System.Windows.Forms.CheckBox cBPediatric;
        private System.Windows.Forms.CheckBox cBNeuro;
        private System.Windows.Forms.CheckBox cBNephro;
        private System.Windows.Forms.Label lFilters;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lAppointments;
        private System.Windows.Forms.DataGridView DGVDoctors;
        private System.Windows.Forms.Label lAvailDocs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.PictureBox pBSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.RadioButton rBTime2;
        private System.Windows.Forms.RadioButton rBTime8;
        private System.Windows.Forms.RadioButton rBTime6;
        private System.Windows.Forms.RadioButton rBTime4;
        private System.Windows.Forms.CheckBox cBAvailNo;
        private System.Windows.Forms.CheckBox cBAvailYes;
        private System.Windows.Forms.Label lAvailable;
        private System.Windows.Forms.Label lSpeciality;
        private System.Windows.Forms.Label lAppType;
        private System.Windows.Forms.CheckBox cBAtHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocFees;
    }
}