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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup SignupObj = new Signup();
            SignupObj.Show();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginObj = new Login();
            LoginObj.Show();
            this.Close();
        }

        private void bAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin la = new LoginAdmin();
            la.Show();
            this.Close();
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
            Application.Exit();
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
