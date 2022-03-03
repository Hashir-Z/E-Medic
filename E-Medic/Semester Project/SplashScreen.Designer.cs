namespace Semester_Project
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pBEMedic = new System.Windows.Forms.PictureBox();
            this.lMotto = new System.Windows.Forms.Label();
            this.pLoadingBar = new System.Windows.Forms.Panel();
            this.LoadingBar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lCredits = new System.Windows.Forms.Label();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bMaximize = new System.Windows.Forms.Button();
            this.lLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBEMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // pBEMedic
            // 
            this.pBEMedic.BackColor = System.Drawing.Color.Transparent;
            this.pBEMedic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBEMedic.Image = ((System.Drawing.Image)(resources.GetObject("pBEMedic.Image")));
            this.pBEMedic.Location = new System.Drawing.Point(275, 2);
            this.pBEMedic.Name = "pBEMedic";
            this.pBEMedic.Size = new System.Drawing.Size(303, 160);
            this.pBEMedic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBEMedic.TabIndex = 5;
            this.pBEMedic.TabStop = false;
            // 
            // lMotto
            // 
            this.lMotto.AutoSize = true;
            this.lMotto.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMotto.ForeColor = System.Drawing.Color.Silver;
            this.lMotto.Location = new System.Drawing.Point(292, 165);
            this.lMotto.Name = "lMotto";
            this.lMotto.Size = new System.Drawing.Size(266, 24);
            this.lMotto.TabIndex = 6;
            this.lMotto.Text = "\"WE CARE ABOUT YOU\"";
            // 
            // pLoadingBar
            // 
            this.pLoadingBar.Location = new System.Drawing.Point(0, 388);
            this.pLoadingBar.Name = "pLoadingBar";
            this.pLoadingBar.Size = new System.Drawing.Size(823, 16);
            this.pLoadingBar.TabIndex = 11;
            // 
            // panel2
            // 
            this.LoadingBar.BackColor = System.Drawing.Color.Lime;
            this.LoadingBar.Location = new System.Drawing.Point(0, 388);
            this.LoadingBar.Name = "panel2";
            this.LoadingBar.Size = new System.Drawing.Size(18, 16);
            this.LoadingBar.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lCredits
            // 
            this.lCredits.AutoSize = true;
            this.lCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCredits.ForeColor = System.Drawing.Color.Silver;
            this.lCredits.Location = new System.Drawing.Point(12, 351);
            this.lCredits.Name = "lCredits";
            this.lCredits.Size = new System.Drawing.Size(807, 18);
            this.lCredits.TabIndex = 13;
            this.lCredits.Text = "Created By:         Hussain Abdullah Gilani         Hashir Bin Zahid         Abdu" +
    "llah Qasim         Hannan Sheikh";
            // 
            // bMinimize
            // 
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bMinimize.Image")));
            this.bMinimize.Location = new System.Drawing.Point(692, 2);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(41, 43);
            this.bMinimize.TabIndex = 16;
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.Location = new System.Drawing.Point(782, 1);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(41, 43);
            this.bClose.TabIndex = 15;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseEnter += new System.EventHandler(this.bClose_MouseEnter);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            // 
            // bMaximize
            // 
            this.bMaximize.FlatAppearance.BorderSize = 0;
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.Image = ((System.Drawing.Image)(resources.GetObject("bMaximize.Image")));
            this.bMaximize.Location = new System.Drawing.Point(739, 2);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Size = new System.Drawing.Size(41, 43);
            this.bMaximize.TabIndex = 14;
            this.bMaximize.UseVisualStyleBackColor = true;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // lLoading
            // 
            this.lLoading.AutoSize = true;
            this.lLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLoading.ForeColor = System.Drawing.Color.Silver;
            this.lLoading.Location = new System.Drawing.Point(347, 231);
            this.lLoading.Name = "lLoading";
            this.lLoading.Size = new System.Drawing.Size(171, 31);
            this.lLoading.TabIndex = 17;
            this.lLoading.Text = "LOADING...";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(824, 404);
            this.Controls.Add(this.lLoading);
            this.Controls.Add(this.bMinimize);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bMaximize);
            this.Controls.Add(this.lCredits);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.pLoadingBar);
            this.Controls.Add(this.lMotto);
            this.Controls.Add(this.pBEMedic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pBEMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBEMedic;
        private System.Windows.Forms.Label lMotto;
        private System.Windows.Forms.Panel pLoadingBar;
        private System.Windows.Forms.Panel LoadingBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lCredits;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bMaximize;
        private System.Windows.Forms.Label lLoading;

    }
}