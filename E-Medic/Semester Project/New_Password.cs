using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class New_Password : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        int pID =0;
        public New_Password(int pID)
        {
            InitializeComponent();
            this.pID =pID;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(tBNewPass.Text!=cBConfPass.Text)
            {
                MessageBox.Show("Passwords Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tBNewPass.Text=="" || cBConfPass.Text=="")
            {
                MessageBox.Show("No Field Can Be Left Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tBNewPass.Text==cBConfPass.Text)
            {
                SqlConnection cnn;
                SqlCommand command;
                cnn = new SqlConnection(connetionString);

                cnn.Open();

                string sql = "Update Patient Set pPassword='"+tBNewPass.Text+ "' where pID='"+pID+"'";
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Password Successfully Updated. Please Login again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Start s6 = new Start();
                s6.Show();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }
    }
}
