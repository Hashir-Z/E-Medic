namespace Semester_Project
{
    partial class New_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Password));
            this.pLogin = new System.Windows.Forms.Panel();
            this.cBConfPass = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tBNewPass = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pLogin.Controls.Add(this.cBConfPass);
            this.pLogin.Controls.Add(this.bClose);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tBNewPass);
            this.pLogin.Controls.Add(this.pBLogo);
            this.pLogin.Location = new System.Drawing.Point(12, 12);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(240, 289);
            this.pLogin.TabIndex = 2;
            // 
            // cBConfPass
            // 
            this.cBConfPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBConfPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cBConfPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBConfPass.Location = new System.Drawing.Point(45, 185);
            this.cBConfPass.Name = "cBConfPass";
            this.cBConfPass.Size = new System.Drawing.Size(156, 20);
            this.cBConfPass.TabIndex = 15;
            this.cBConfPass.WaterMark = "Confirm Password";
            this.cBConfPass.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cBConfPass.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBConfPass.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.Location = new System.Drawing.Point(3, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(26, 38);
            this.bClose.TabIndex = 14;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bLogin
            // 
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogin.Location = new System.Drawing.Point(58, 237);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(120, 33);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Change";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tBNewPass
            // 
            this.tBNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBNewPass.Location = new System.Drawing.Point(45, 144);
            this.tBNewPass.Name = "tBNewPass";
            this.tBNewPass.Size = new System.Drawing.Size(156, 20);
            this.tBNewPass.TabIndex = 1;
            this.tBNewPass.WaterMark = "New Password";
            this.tBNewPass.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBNewPass.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewPass.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // pBLogo
            // 
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(3, 15);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(237, 90);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // New_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(265, 315);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Password";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bLogin;
        private ChreneLib.Controls.TextBoxes.CTextBox tBNewPass;
        private System.Windows.Forms.PictureBox pBLogo;
        private ChreneLib.Controls.TextBoxes.CTextBox cBConfPass;
    }
}