using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingBar.Width += 3;
            if(LoadingBar.Width>=824)
            {
                timer1.Stop();
                this.Hide();
                Start s = new Start();
                s.Show();
            }
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClose_MouseEnter(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.Red;
        }

        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
        }
    }
}