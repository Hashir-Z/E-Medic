namespace Semester_Project
{
    partial class Patient_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Portal));
            this.bClose = new System.Windows.Forms.Button();
            this.pSidePanel = new System.Windows.Forms.Panel();
            this.pProfileInfoActive = new System.Windows.Forms.Panel();
            this.pAppRecordsActive = new System.Windows.Forms.Panel();
            this.pPaymentActive = new System.Windows.Forms.Panel();
            this.pAppointmentActive = new System.Windows.Forms.Panel();
            this.pReportActive = new System.Windows.Forms.Panel();
            this.pBloodTestActive = new System.Windows.Forms.Panel();
            this.pDashboardActive = new System.Windows.Forms.Panel();
            this.bLogout = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.pUserInfo = new System.Windows.Forms.Panel();
            this.pBUserIcon = new System.Windows.Forms.PictureBox();
            this.pUsername = new System.Windows.Forms.Panel();
            this.lUsername = new System.Windows.Forms.Label();
            this.pAge = new System.Windows.Forms.Panel();
            this.lAge = new System.Windows.Forms.Label();
            this.pFormArea = new System.Windows.Forms.Panel();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bMaximize = new System.Windows.Forms.Button();
            this.lWelcome = new System.Windows.Forms.Label();
            this.bTest = new System.Windows.Forms.Button();
            this.bReports = new System.Windows.Forms.Button();
            this.bPayments = new System.Windows.Forms.Button();
            this.bAppointment = new System.Windows.Forms.Button();
            this.bAppRecords = new System.Windows.Forms.Button();
            this.bProfileInfo = new System.Windows.Forms.Button();
            this.pSidePanel.SuspendLayout();
            this.pUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).BeginInit();
            this.pUsername.SuspendLayout();
            this.pAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.Location = new System.Drawing.Point(787, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(41, 42);
            this.bClose.TabIndex = 7;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseEnter += new System.EventHandler(this.bClose_MouseEnter);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            // 
            // pSidePanel
            // 
            this.pSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pSidePanel.Controls.Add(this.pProfileInfoActive);
            this.pSidePanel.Controls.Add(this.pAppRecordsActive);
            this.pSidePanel.Controls.Add(this.pAppointmentActive);
            this.pSidePanel.Controls.Add(this.pReportActive);
            this.pSidePanel.Controls.Add(this.pBloodTestActive);
            this.pSidePanel.Controls.Add(this.pDashboardActive);
            this.pSidePanel.Controls.Add(this.bLogout);
            this.pSidePanel.Controls.Add(this.bDashboard);
            this.pSidePanel.Controls.Add(this.pUserInfo);
            this.pSidePanel.Controls.Add(this.pPaymentActive);
            this.pSidePanel.Controls.Add(this.bTest);
            this.pSidePanel.Controls.Add(this.bReports);
            this.pSidePanel.Controls.Add(this.bPayments);
            this.pSidePanel.Controls.Add(this.bAppointment);
            this.pSidePanel.Controls.Add(this.bAppRecords);
            this.pSidePanel.Controls.Add(this.bProfileInfo);
            this.pSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pSidePanel.Name = "pSidePanel";
            this.pSidePanel.Size = new System.Drawing.Size(181, 633);
            this.pSidePanel.TabIndex = 13;
            // 
            // pProfileInfoActive
            // 
            this.pProfileInfoActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pProfileInfoActive.Location = new System.Drawing.Point(0, 491);
            this.pProfileInfoActive.Name = "pProfileInfoActive";
            this.pProfileInfoActive.Size = new System.Drawing.Size(3, 52);
            this.pProfileInfoActive.TabIndex = 104;
            // 
            // pAppRecordsActive
            // 
            this.pAppRecordsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pAppRecordsActive.Location = new System.Drawing.Point(0, 434);
            this.pAppRecordsActive.Name = "pAppRecordsActive";
            this.pAppRecordsActive.Size = new System.Drawing.Size(3, 52);
            this.pAppRecordsActive.TabIndex = 102;
            // 
            // pPaymentActive
            // 
            this.pPaymentActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pPaymentActive.Location = new System.Drawing.Point(0, 320);
            this.pPaymentActive.Name = "pPaymentActive";
            this.pPaymentActive.Size = new System.Drawing.Size(3, 52);
            this.pPaymentActive.TabIndex = 100;
            // 
            // pAppointmentActive
            // 
            this.pAppointmentActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pAppointmentActive.Location = new System.Drawing.Point(0, 377);
            this.pAppointmentActive.Name = "pAppointmentActive";
            this.pAppointmentActive.Size = new System.Drawing.Size(3, 52);
            this.pAppointmentActive.TabIndex = 100;
            // 
            // pReportActive
            // 
            this.pReportActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pReportActive.Location = new System.Drawing.Point(0, 263);
            this.pReportActive.Name = "pReportActive";
            this.pReportActive.Size = new System.Drawing.Size(3, 52);
            this.pReportActive.TabIndex = 100;
            // 
            // pBloodTestActive
            // 
            this.pBloodTestActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pBloodTestActive.Location = new System.Drawing.Point(0, 206);
            this.pBloodTestActive.Name = "pBloodTestActive";
            this.pBloodTestActive.Size = new System.Drawing.Size(3, 52);
            this.pBloodTestActive.TabIndex = 100;
            // 
            // pDashboardActive
            // 
            this.pDashboardActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pDashboardActive.Location = new System.Drawing.Point(0, 151);
            this.pDashboardActive.Name = "pDashboardActive";
            this.pDashboardActive.Size = new System.Drawing.Size(3, 52);
            this.pDashboardActive.TabIndex = 100;
            // 
            // bLogout
            // 
            this.bLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bLogout.FlatAppearance.BorderSize = 0;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogout.Image = ((System.Drawing.Image)(resources.GetObject("bLogout.Image")));
            this.bLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bLogout.Location = new System.Drawing.Point(0, 577);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(181, 56);
            this.bLogout.TabIndex = 8;
            this.bLogout.Text = "Log Out";
            this.bLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDashboard.FlatAppearance.BorderSize = 0;
            this.bDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bDashboard.Image = ((System.Drawing.Image)(resources.GetObject("bDashboard.Image")));
            this.bDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDashboard.Location = new System.Drawing.Point(0, 149);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(181, 57);
            this.bDashboard.TabIndex = 1;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // pUserInfo
            // 
            this.pUserInfo.Controls.Add(this.pBUserIcon);
            this.pUserInfo.Controls.Add(this.pUsername);
            this.pUserInfo.Controls.Add(this.pAge);
            this.pUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pUserInfo.Name = "pUserInfo";
            this.pUserInfo.Size = new System.Drawing.Size(181, 149);
            this.pUserInfo.TabIndex = 0;
            // 
            // pBUserIcon
            // 
            this.pBUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pBUserIcon.Image")));
            this.pBUserIcon.Location = new System.Drawing.Point(62, 12);
            this.pBUserIcon.Name = "pBUserIcon";
            this.pBUserIcon.Size = new System.Drawing.Size(57, 59);
            this.pBUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBUserIcon.TabIndex = 0;
            this.pBUserIcon.TabStop = false;
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.lUsername);
            this.pUsername.Location = new System.Drawing.Point(3, 84);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(174, 23);
            this.pUsername.TabIndex = 6;
            // 
            // lUsername
            // 
            this.lUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.lUsername.Location = new System.Drawing.Point(0, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(174, 23);
            this.lUsername.TabIndex = 4;
            this.lUsername.Text = "Username";
            this.lUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pAge
            // 
            this.pAge.Controls.Add(this.lAge);
            this.pAge.Location = new System.Drawing.Point(6, 110);
            this.pAge.Name = "pAge";
            this.pAge.Size = new System.Drawing.Size(171, 21);
            this.pAge.TabIndex = 0;
            // 
            // lAge
            // 
            this.lAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAge.Location = new System.Drawing.Point(0, 0);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(171, 21);
            this.lAge.TabIndex = 5;
            this.lAge.Text = "Age: ";
            this.lAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFormArea
            // 
            this.pFormArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormArea.BackColor = System.Drawing.Color.Transparent;
            this.pFormArea.Location = new System.Drawing.Point(187, 48);
            this.pFormArea.Name = "pFormArea";
            this.pFormArea.Size = new System.Drawing.Size(630, 573);
            this.pFormArea.TabIndex = 14;
            // 
            // bMinimize
            // 
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bMinimize.Image")));
            this.bMinimize.Location = new System.Drawing.Point(693, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(41, 42);
            this.bMinimize.TabIndex = 17;
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bMaximize
            // 
            this.bMaximize.FlatAppearance.BorderSize = 0;
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.Image = ((System.Drawing.Image)(resources.GetObject("bMaximize.Image")));
            this.bMaximize.Location = new System.Drawing.Point(740, 0);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Size = new System.Drawing.Size(41, 42);
            this.bMaximize.TabIndex = 15;
            this.bMaximize.UseVisualStyleBackColor = true;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lWelcome.Location = new System.Drawing.Point(190, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(167, 45);
            this.lWelcome.TabIndex = 18;
            this.lWelcome.Text = "Welcome,";
            // 
            // bTest
            // 
            this.bTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTest.FlatAppearance.BorderSize = 0;
            this.bTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bTest.Image = ((System.Drawing.Image)(resources.GetObject("bTest.Image")));
            this.bTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTest.Location = new System.Drawing.Point(0, 206);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(181, 57);
            this.bTest.TabIndex = 2;
            this.bTest.Text = "Blood Tests";
            this.bTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Click += new System.EventHandler(this.bTest_Click);
            // 
            // bReports
            // 
            this.bReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bReports.FlatAppearance.BorderSize = 0;
            this.bReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bReports.Image = ((System.Drawing.Image)(resources.GetObject("bReports.Image")));
            this.bReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReports.Location = new System.Drawing.Point(0, 263);
            this.bReports.Name = "bReports";
            this.bReports.Size = new System.Drawing.Size(181, 57);
            this.bReports.TabIndex = 3;
            this.bReports.Text = "Reports";
            this.bReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReports.UseVisualStyleBackColor = true;
            this.bReports.Click += new System.EventHandler(this.bReports_Click);
            // 
            // bPayments
            // 
            this.bPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPayments.FlatAppearance.BorderSize = 0;
            this.bPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bPayments.Image = ((System.Drawing.Image)(resources.GetObject("bPayments.Image")));
            this.bPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPayments.Location = new System.Drawing.Point(0, 320);
            this.bPayments.Name = "bPayments";
            this.bPayments.Size = new System.Drawing.Size(181, 57);
            this.bPayments.TabIndex = 4;
            this.bPayments.Text = "Payments";
            this.bPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPayments.UseVisualStyleBackColor = true;
            this.bPayments.Click += new System.EventHandler(this.bPayments_Click);
            // 
            // bAppointment
            // 
            this.bAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAppointment.FlatAppearance.BorderSize = 0;
            this.bAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bAppointment.Image = ((System.Drawing.Image)(resources.GetObject("bAppointment.Image")));
            this.bAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAppointment.Location = new System.Drawing.Point(0, 377);
            this.bAppointment.Name = "bAppointment";
            this.bAppointment.Size = new System.Drawing.Size(181, 57);
            this.bAppointment.TabIndex = 5;
            this.bAppointment.Text = "Appointment";
            this.bAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAppointment.UseVisualStyleBackColor = true;
            this.bAppointment.Click += new System.EventHandler(this.bAppointment_Click);
            // 
            // bAppRecords
            // 
            this.bAppRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAppRecords.FlatAppearance.BorderSize = 0;
            this.bAppRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAppRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAppRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bAppRecords.Image = ((System.Drawing.Image)(resources.GetObject("bAppRecords.Image")));
            this.bAppRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAppRecords.Location = new System.Drawing.Point(0, 434);
            this.bAppRecords.Name = "bAppRecords";
            this.bAppRecords.Size = new System.Drawing.Size(181, 57);
            this.bAppRecords.TabIndex = 6;
            this.bAppRecords.Text = "Appointment Records";
            this.bAppRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAppRecords.UseVisualStyleBackColor = true;
            this.bAppRecords.Click += new System.EventHandler(this.bAppRecords_Click);
            // 
            // bProfileInfo
            // 
            this.bProfileInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bProfileInfo.FlatAppearance.BorderSize = 0;
            this.bProfileInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProfileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bProfileInfo.Image = ((System.Drawing.Image)(resources.GetObject("bProfileInfo.Image")));
            this.bProfileInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bProfileInfo.Location = new System.Drawing.Point(0, 491);
            this.bProfileInfo.Name = "bProfileInfo";
            this.bProfileInfo.Size = new System.Drawing.Size(181, 50);
            this.bProfileInfo.TabIndex = 7;
            this.bProfileInfo.Text = "Profile Info";
            this.bProfileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProfileInfo.UseVisualStyleBackColor = true;
            this.bProfileInfo.Click += new System.EventHandler(this.bProfileInfo_Click);
            // 
            // Patient_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(829, 633);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.bMinimize);
            this.Controls.Add(this.bMaximize);
            this.Controls.Add(this.pFormArea);
            this.Controls.Add(this.pSidePanel);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Portal";
            this.Load += new System.EventHandler(this.Patient_Portal_Load);
            this.pSidePanel.ResumeLayout(false);
            this.pUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).EndInit();
            this.pUsername.ResumeLayout(false);
            this.pAge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel pSidePanel;
        private System.Windows.Forms.Panel pUserInfo;
        private System.Windows.Forms.PictureBox pBUserIcon;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel pDashboardActive;
        private System.Windows.Forms.Panel pPaymentActive;
        private System.Windows.Forms.Panel pAppointmentActive;
        private System.Windows.Forms.Panel pBloodTestActive;
        private System.Windows.Forms.Panel pReportActive;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Panel pFormArea;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.Panel pAge;
        private System.Windows.Forms.Panel pAppRecordsActive;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Button bMaximize;
        private System.Windows.Forms.Panel pProfileInfoActive;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Button bReports;
        private System.Windows.Forms.Button bPayments;
        private System.Windows.Forms.Button bAppointment;
        private System.Windows.Forms.Button bAppRecords;
        private System.Windows.Forms.Button bProfileInfo;
    }
}