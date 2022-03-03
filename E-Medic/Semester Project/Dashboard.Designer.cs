namespace Semester_Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.calTable = new Calendar.NET.Calendar();
            this.lPendingRep = new System.Windows.Forms.Label();
            this.pReports = new System.Windows.Forms.Panel();
            this.lReports = new System.Windows.Forms.Label();
            this.pBPendingRep = new System.Windows.Forms.PictureBox();
            this.pApp = new System.Windows.Forms.Panel();
            this.lPendApp = new System.Windows.Forms.Label();
            this.pBApp = new System.Windows.Forms.PictureBox();
            this.lApp = new System.Windows.Forms.Label();
            this.lAmntPaid = new System.Windows.Forms.Label();
            this.pBAmntPaid = new System.Windows.Forms.PictureBox();
            this.lRepAmntPaid = new System.Windows.Forms.Label();
            this.pAmntPaid = new System.Windows.Forms.Panel();
            this.pReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPendingRep)).BeginInit();
            this.pApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmntPaid)).BeginInit();
            this.pAmntPaid.SuspendLayout();
            this.SuspendLayout();
            // 
            // calTable
            // 
            this.calTable.AllowEditingEvents = false;
            this.calTable.BackColor = System.Drawing.Color.DimGray;
            this.calTable.CalendarDate = new System.DateTime(2021, 5, 30, 18, 11, 37, 923);
            this.calTable.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calTable.DateHeaderFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTable.DayOfWeekFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTable.DaysFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTable.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calTable.DimDisabledEvents = true;
            this.calTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.calTable.HighlightCurrentDay = true;
            this.calTable.LoadPresetHolidays = true;
            this.calTable.Location = new System.Drawing.Point(12, 148);
            this.calTable.Name = "calTable";
            this.calTable.ShowArrowControls = true;
            this.calTable.ShowDashedBorderOnDisabledEvents = true;
            this.calTable.ShowDateInHeader = true;
            this.calTable.ShowDisabledEvents = true;
            this.calTable.ShowEventTooltips = true;
            this.calTable.ShowTodayButton = true;
            this.calTable.Size = new System.Drawing.Size(596, 381);
            this.calTable.TabIndex = 0;
            this.calTable.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // lPendingRep
            // 
            this.lPendingRep.AutoSize = true;
            this.lPendingRep.BackColor = System.Drawing.Color.Transparent;
            this.lPendingRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPendingRep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lPendingRep.Location = new System.Drawing.Point(-4, 3);
            this.lPendingRep.Name = "lPendingRep";
            this.lPendingRep.Size = new System.Drawing.Size(166, 24);
            this.lPendingRep.TabIndex = 4;
            this.lPendingRep.Text = "Pending Reports";
            // 
            // pReports
            // 
            this.pReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pReports.BackgroundImage")));
            this.pReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pReports.Controls.Add(this.lReports);
            this.pReports.Controls.Add(this.pBPendingRep);
            this.pReports.Controls.Add(this.lPendingRep);
            this.pReports.Location = new System.Drawing.Point(12, 42);
            this.pReports.Name = "pReports";
            this.pReports.Size = new System.Drawing.Size(196, 100);
            this.pReports.TabIndex = 5;
            // 
            // lReports
            // 
            this.lReports.AutoSize = true;
            this.lReports.BackColor = System.Drawing.Color.Transparent;
            this.lReports.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lReports.Location = new System.Drawing.Point(25, 40);
            this.lReports.Name = "lReports";
            this.lReports.Size = new System.Drawing.Size(148, 47);
            this.lReports.TabIndex = 8;
            this.lReports.Text = "Reports";
            // 
            // pBPendingRep
            // 
            this.pBPendingRep.BackColor = System.Drawing.Color.Transparent;
            this.pBPendingRep.Image = ((System.Drawing.Image)(resources.GetObject("pBPendingRep.Image")));
            this.pBPendingRep.Location = new System.Drawing.Point(159, 3);
            this.pBPendingRep.Name = "pBPendingRep";
            this.pBPendingRep.Size = new System.Drawing.Size(37, 34);
            this.pBPendingRep.TabIndex = 7;
            this.pBPendingRep.TabStop = false;
            // 
            // pApp
            // 
            this.pApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pApp.BackgroundImage")));
            this.pApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pApp.Controls.Add(this.lPendApp);
            this.pApp.Controls.Add(this.pBApp);
            this.pApp.Controls.Add(this.lApp);
            this.pApp.Location = new System.Drawing.Point(214, 42);
            this.pApp.Name = "pApp";
            this.pApp.Size = new System.Drawing.Size(189, 100);
            this.pApp.TabIndex = 6;
            // 
            // lPendApp
            // 
            this.lPendApp.AutoSize = true;
            this.lPendApp.BackColor = System.Drawing.Color.Transparent;
            this.lPendApp.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPendApp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lPendApp.Location = new System.Drawing.Point(24, 40);
            this.lPendApp.Name = "lPendApp";
            this.lPendApp.Size = new System.Drawing.Size(148, 47);
            this.lPendApp.TabIndex = 10;
            this.lPendApp.Text = "Reports";
            // 
            // pBApp
            // 
            this.pBApp.BackColor = System.Drawing.Color.Transparent;
            this.pBApp.Image = ((System.Drawing.Image)(resources.GetObject("pBApp.Image")));
            this.pBApp.Location = new System.Drawing.Point(147, 3);
            this.pBApp.Name = "pBApp";
            this.pBApp.Size = new System.Drawing.Size(35, 34);
            this.pBApp.TabIndex = 9;
            this.pBApp.TabStop = false;
            // 
            // lApp
            // 
            this.lApp.AutoSize = true;
            this.lApp.BackColor = System.Drawing.Color.Transparent;
            this.lApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lApp.Location = new System.Drawing.Point(3, 3);
            this.lApp.Name = "lApp";
            this.lApp.Size = new System.Drawing.Size(138, 24);
            this.lApp.TabIndex = 5;
            this.lApp.Text = "Appointments";
            // 
            // lAmntPaid
            // 
            this.lAmntPaid.AutoSize = true;
            this.lAmntPaid.BackColor = System.Drawing.Color.Transparent;
            this.lAmntPaid.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmntPaid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lAmntPaid.Location = new System.Drawing.Point(26, 40);
            this.lAmntPaid.Name = "lAmntPaid";
            this.lAmntPaid.Size = new System.Drawing.Size(148, 47);
            this.lAmntPaid.TabIndex = 11;
            this.lAmntPaid.Text = "Reports";
            // 
            // pBAmntPaid
            // 
            this.pBAmntPaid.BackColor = System.Drawing.Color.Transparent;
            this.pBAmntPaid.Image = ((System.Drawing.Image)(resources.GetObject("pBAmntPaid.Image")));
            this.pBAmntPaid.Location = new System.Drawing.Point(161, 0);
            this.pBAmntPaid.Name = "pBAmntPaid";
            this.pBAmntPaid.Size = new System.Drawing.Size(35, 34);
            this.pBAmntPaid.TabIndex = 10;
            this.pBAmntPaid.TabStop = false;
            // 
            // lRepAmntPaid
            // 
            this.lRepAmntPaid.AutoSize = true;
            this.lRepAmntPaid.BackColor = System.Drawing.Color.Transparent;
            this.lRepAmntPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepAmntPaid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lRepAmntPaid.Location = new System.Drawing.Point(0, 0);
            this.lRepAmntPaid.Name = "lRepAmntPaid";
            this.lRepAmntPaid.Size = new System.Drawing.Size(160, 48);
            this.lRepAmntPaid.TabIndex = 6;
            this.lRepAmntPaid.Text = "Reports Amount\r\nPaid";
            // 
            // pAmntPaid
            // 
            this.pAmntPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pAmntPaid.BackgroundImage")));
            this.pAmntPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAmntPaid.Controls.Add(this.lRepAmntPaid);
            this.pAmntPaid.Controls.Add(this.lAmntPaid);
            this.pAmntPaid.Controls.Add(this.pBAmntPaid);
            this.pAmntPaid.Location = new System.Drawing.Point(409, 42);
            this.pAmntPaid.Name = "pAmntPaid";
            this.pAmntPaid.Size = new System.Drawing.Size(199, 100);
            this.pAmntPaid.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(620, 541);
            this.Controls.Add(this.pAmntPaid);
            this.Controls.Add(this.pApp);
            this.Controls.Add(this.pReports);
            this.Controls.Add(this.calTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.VisibleChanged += new System.EventHandler(this.Dashboard_VisibleChanged);
            this.pReports.ResumeLayout(false);
            this.pReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPendingRep)).EndInit();
            this.pApp.ResumeLayout(false);
            this.pApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmntPaid)).EndInit();
            this.pAmntPaid.ResumeLayout(false);
            this.pAmntPaid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar.NET.Calendar calTable;
        private System.Windows.Forms.Label lPendingRep;
        private System.Windows.Forms.Panel pReports;
        private System.Windows.Forms.Panel pApp;
        private System.Windows.Forms.Label lApp;
        private System.Windows.Forms.Label lReports;
        private System.Windows.Forms.PictureBox pBPendingRep;
        private System.Windows.Forms.Label lPendApp;
        private System.Windows.Forms.PictureBox pBApp;
        private System.Windows.Forms.Label lAmntPaid;
        private System.Windows.Forms.PictureBox pBAmntPaid;
        private System.Windows.Forms.Label lRepAmntPaid;
        private System.Windows.Forms.Panel pAmntPaid;



    }
}