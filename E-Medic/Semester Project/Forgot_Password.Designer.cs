namespace Semester_Project
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.pLogin = new System.Windows.Forms.Panel();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.tBEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pLogin.Controls.Add(this.bBack);
            this.pLogin.Controls.Add(this.bNext);
            this.pLogin.Controls.Add(this.tBEmail);
            this.pLogin.Controls.Add(this.pBLogo);
            this.pLogin.Location = new System.Drawing.Point(10, 10);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(240, 277);
            this.pLogin.TabIndex = 1;
            // 
            // bBack
            // 
            this.bBack.FlatAppearance.BorderSize = 0;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Image = ((System.Drawing.Image)(resources.GetObject("bBack.Image")));
            this.bBack.Location = new System.Drawing.Point(3, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(26, 38);
            this.bBack.TabIndex = 14;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bNext
            // 
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bNext.Location = new System.Drawing.Point(62, 201);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(120, 33);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBEmail.Location = new System.Drawing.Point(45, 144);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(156, 20);
            this.tBEmail.TabIndex = 1;
            this.tBEmail.WaterMark = "Enter Your Email";
            this.tBEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // pBLogo
            // 
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(0, 27);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(240, 90);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(262, 299);
            this.Controls.Add(this.pLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bNext;
        private ChreneLib.Controls.TextBoxes.CTextBox tBEmail;
        private System.Windows.Forms.PictureBox pBLogo;
    }
}