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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            // Gillani
            //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

            // Hashir
            string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

            SqlConnection cnn;
            SqlCommand command;
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            string sql = "SELECT pID, pPassword FROM Patient WHERE pEmail='" + tBEmail.Text + "' AND pIsDelete!='Yes'";
            string Password = "";

            command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            int Email = 0;
            while(dataReader.Read())
            {
                Email = dataReader.GetInt32(0);
                Password = dataReader.GetString(1);
            }
            if(Email==0)
            {
                MessageBox.Show("Wrong Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //this.Hide();
                //New_Password np1 = new New_Password(email);
                //np1.Show();
                //this.Close();


                var proc = System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\SendMail.exe ", tBEmail.Text + " " + Password);
                MessageBox.Show("Password Sent To Email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Start StartObj = new Start();
                StartObj.Show();
                this.Close();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
