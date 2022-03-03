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
    public partial class ProfileInfo : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";
        int pID;
        private Patient_Portal Obj;

        public ProfileInfo(int pID, Patient_Portal Obj)
        {
            InitializeComponent();
            this.pID = pID;
            this.Obj = Obj;
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void bEditPers_Click(object sender, EventArgs e)
        {
            if (bEditPers.Text == "Edit")
            {
                tBFName.Enabled = true;
                tBLName.Enabled = true;
                cBAge.Enabled = true;
                tBPhone.Enabled = true;
                tBFatherName.Enabled = true;
                tBFPhone.Enabled = true;

                bEditPers.Text = "Update";
            }
            else
            {
                if (tBFName.Text == "" ||
                    tBLName.Text == "" ||
                    tBPhone.Text == "" ||
                    tBFPhone.Text == "" ||
                    tBFatherName.Text == ""
                    )
                {
                    MessageBox.Show("Please Fill All Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UpdateData();
                MessageBox.Show("Data Has Been Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tBFName.Enabled = false;
                tBLName.Enabled = false;
                cBAge.Enabled = false;
                tBPhone.Enabled = false;
                tBFatherName.Enabled = false;
                tBFPhone.Enabled = false;

                bEditPers.Text = "Edit";
            }
        }

        private void bEditAcc_Click(object sender, EventArgs e)
        {
            if (bEditAcc.Text == "Edit")
            {
                tBEmail.Enabled = true;
                tBPassword.Enabled = true;
                tBConfirmPass.Enabled = true;

                bEditAcc.Text = "Update";
            }
            else
            {
                UpdateAccData();

                tBEmail.Enabled = false;
                tBPassword.Enabled = false;
                tBConfirmPass.Enabled = false;

                bEditAcc.Text = "Edit";
            }
        }

        private void cBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cBConfirm.Checked == true)
            {
                bDeleteAcc.Enabled = true;
            }
            if (cBConfirm.Checked == false)
            {
                bDeleteAcc.Enabled = false;
            }
        }

        private void bDeleteAcc_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Update Patient Data
            string sql = "UPDATE Patient SET pIsDeleted='Yes'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Account Successfully Deleted!\nPlease Login To Continue", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Start s = new Start();
            s.Show();
            Obj.Close();
            this.Close();
        }

        private void LoadPersonData()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Data
            string sql = "SELECT pName, pAge, pGender, pPhoneNum, pCNIC, pEmail FROM Patient WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                // Divide pName field into First Name & Last Name Format
                // Source: https://www.codeproject.com/Questions/1144522/How-to-split-string-and-pick-a-single-word-in-Csha
                string[] parts = dataReader.GetString(0).Split(' ');
                bool run = true;
                foreach (string part in parts)
                {
                    string[] subParts = part.Split(' ');
                    if (subParts.Length > 0)
                    {
                        if (run)
                        {
                            tBFName.Text = subParts[0];
                            run = false;
                        }
                        else
                        {
                            tBLName.Text += subParts[0] + " ";
                        }
                    }
                }

                cBAge.Text = Convert.ToString(dataReader.GetInt32(1));
                cBGender.Text = dataReader.GetString(2);
                tBPhone.Text = dataReader.GetString(3);
                mTBCNIC.Text = dataReader.GetString(4);
                tBEmail.Text = dataReader.GetString(5);
            }

            dataReader.Close();
            dataReader.Dispose();

            // Load Patient Father Data
            sql = "SELECT pFName, pFPhoneNum, pFCNIC FROM pFather WHERE pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                tBFatherName.Text = dataReader.GetString(0);
                tBFPhone.Text = dataReader.GetString(1);
                mTBFCNIC.Text = dataReader.GetString(2);
            }
        }

        private void UpdateData()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Update Patient Data
            string sql = "UPDATE Patient SET " +
                "pName='" + tBFName.Text + " " + tBLName.Text + "', " +
                "pAge='" + cBAge.Text + "', " +
                "pPhoneNum='" + tBPhone.Text + "' " +
                "WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            // Update Patient Father Data
            sql = "UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                "pFPhoneNum='" + tBFPhone.Text + "' " +
                "WHERE pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
        }

        private void UpdateAccData()
        {
            if (tBConfirmPass.Text != tBPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tBPassword.Text == "" && tBConfirmPass.Text == "")
            {
                MessageBox.Show("Passwords Cannot be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tBEmail.Text == "")
            {
                MessageBox.Show("Email Field Cannot be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RecordExists("pEmail", tBEmail.Text))
            {
                MessageBox.Show("User With Given Email Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();

                // Update Patient Data
                string sql = "UPDATE Patient SET " +
                    "pEmail='" + tBEmail.Text + "', " +
                    "pPassword='" + tBPassword.Text + "' " +
                    "WHERE pID='" + pID + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();

                MessageBox.Show("Data Has Been Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadPersonData();
        }

        private bool RecordExists(string Column, string Value)
        {
            SqlConnection cnn;
            SqlCommand command;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            // See if Value already Exists

            string sql = "SELECT " + Column + ", count(*) as c FROM Patient WHERE " + Column + "='" + Value + "' AND pIsDeleted!='Yes' GROUP BY " + Column;
            command = new SqlCommand(sql, cnn);
            int result = 0;

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                result = dataReader.GetInt32(1);
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
