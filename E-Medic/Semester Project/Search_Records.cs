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
    public partial class Search_Records : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        SqlConnection cnn;
        SqlCommand cmd;
        int pID;
        string fcnic;
        string cnic;

        public Search_Records(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Search_Records_Load(object sender, EventArgs e)
        {
            UpdateDGV();
            if (DGVPatients.RowCount != 0)
            {
                DGVPatients.Rows[0].Selected = true;
            }
            LoadFields();
        }

        private void DGVPatients_VisibleChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void cBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (cBSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Please Select An Option From The \"Search By\" Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DGVPatients.Rows.Clear();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string item = cBSearchBy.SelectedItem.ToString();
                string txt = tBSearch.Text;
                if (item == "Name")
                {
                    // Load Patient Data
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC,pIsDeleted from Patient,pFather WHERE Patient.pID=pFather.pID and pName LIKE '" + '%' + txt + '%' + "'";
                    cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9), dataReader.GetString(10));
                    }
                }
                if (item == "CNIC")
                {
                    DGVPatients.Rows.Clear();
                    // Load Patient Data
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC,pIsDeleted from Patient,pFather WHERE Patient.pID=pFather.pID and pCNIC LIKE '" + '%' + txt + '%' + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9), dataReader.GetString(10));
                    }
                }
                if (item == "Age")
                {
                    DGVPatients.Rows.Clear();
                    // Load Patient Data
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC,pIsDeleted from Patient,pFather WHERE Patient.pID=pFather.pID and pAge LIKE '" + '%' + txt + '%' + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9), dataReader.GetString(10));
                    }
                }
                cnn.Close();
                LoadFields();
            }
        }

        private void DGVPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (tBFName.Text == "" || 
                tBLName.Text == "" ||
                tBPhone.Text == "" ||
                mTBCNIC.Text == "" ||
                tBEmail.Text == "" ||
                mTBFCNIC.Text == "" ||
                tBFPhone.Text == "" ||
                tBPassword.Text == "" ||
                tBFatherName.Text == "" ||
                cBAge.SelectedItem == null || 
                cBGender.SelectedItem == null)
            {
                MessageBox.Show("Please Enter All The Details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cBEnable.Checked == true)
            {
                if ((tBNewPassword.Text == "" || tBConfPass.Text == "") || (tBNewPassword.Text != tBConfPass.Text))
                {
                    MessageBox.Show("Passwords don't Match Or are Empty!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string name = tBFName.Text + " " + tBLName.Text;

                string s = "UPDATE Patient SET " +
                "pName='" + name + "', " +
                 "pAge='" + cBAge.SelectedItem.ToString() + "', " +
                  "pGender='" + cBGender.SelectedItem.ToString() + "', " +
                   "pPhoneNum='" + tBPhone.Text + "', " +
                    "pCNIC='" + mTBCNIC.Text + "', " +
                     "pEmail='" + tBEmail.Text + "', " +
                      "pPassword='" + tBNewPassword.Text + "' " +
                "WHERE pCNIC='" + cnic + "'";

                SqlCommand command = new SqlCommand(s, cnn);
                command.ExecuteNonQuery();

                string s1 = "UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                 "pFPhoneNum='" + tBFPhone.Text + "', " +
                  "pFCNIC='" + mTBFCNIC.Text + "' " +
                  "WHERE pFCNIC='" + fcnic + "'";

                SqlCommand command1 = new SqlCommand(s1, cnn);
                command1.ExecuteNonQuery();

                MessageBox.Show("Patient Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string name = tBFName.Text + " " + tBLName.Text;

                string s = "UPDATE Patient SET " +
                "pName='" + name + "', " +
                 "pAge='" + cBAge.SelectedItem.ToString() + "', " +
                  "pGender='" + cBGender.SelectedItem.ToString() + "', " +
                   "pPhoneNum='" + tBPhone.Text + "', " +
                    "pCNIC='" + mTBCNIC.Text + "', " +
                     "pEmail='" + tBEmail.Text + "', " +
                      "pPassword='" + tBPassword.Text + "' " +
                "WHERE pCNIC='" + cnic + "'";

                SqlCommand command = new SqlCommand(s, cnn);
                command.ExecuteNonQuery();

                string s1 = "UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                 "pFPhoneNum='" + tBFPhone.Text + "', " +
                  "pFCNIC='" + mTBFCNIC.Text + "' " +
                  "WHERE pFCNIC='" + fcnic + "'";

                SqlCommand command1 = new SqlCommand(s1, cnn);
                command1.ExecuteNonQuery();

                MessageBox.Show("Patient Data Added Successfully !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            UpdateDGV();
            LoadFields();
        }

        private void cBEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cBEnable.Checked == true)
            {
                tBEmail.Enabled = true;
                tBPassword.Enabled = true;
                tBNewPassword.Enabled = true;
                tBConfPass.Enabled = true;
            }
            else if (cBEnable.Enabled == false)
            {
                tBEmail.Enabled = false;
                tBPassword.Enabled = false;
                tBNewPassword.Enabled = false;
                tBConfPass.Enabled = false;
            }
        }

        private void ResetFields()
        {
            tBFName.Text = "";
            tBLName.Text = "";
            cBAge.SelectedItem = "";
            cBGender.SelectedItem = "";
            tBPhone.Text = "";
            mTBCNIC.Text = "";
            tBEmail.Text = "";
            tBPassword.Text = "";
            tBFatherName.Text = "";
            tBFPhone.Text = "";
            mTBFCNIC.Text = "";
            tBNewPassword.Text = "";
            tBConfPass.Text = "";
            cBEnable.Checked = false;
        }

        private void UpdateDGV()
        {
            DGVPatients.Rows.Clear();
            DGVPatients.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Doctor Data
            string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC,pIsDeleted from Patient,pFather WHERE Patient.pID=pFather.pID";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9), dataReader.GetString(10));
            }
        }

        private void LoadFields()
        {
            if (DGVPatients.SelectedRows.Count >= 0 && DGVPatients.RowCount != 0)
            {
                DataGridViewRow row = this.DGVPatients.Rows[DGVPatients.CurrentCell.RowIndex];

                string tid1 = row.Cells[0].Value.ToString();
                Int32 count = 2;
                char[] sep = { ' ' };
                string[] split = tid1.Split(sep, count, StringSplitOptions.None);
                tBFName.Text = split[0];
                tBLName.Text = split[1];
                cBAge.SelectedItem = row.Cells[1].Value;
                cBGender.SelectedItem = row.Cells[2].Value;
                tBPhone.Text = row.Cells[3].Value.ToString();
                mTBCNIC.Text = row.Cells[4].Value.ToString();
                cnic = row.Cells[4].Value.ToString();
                tBEmail.Text = row.Cells[5].Value.ToString();
                tBPassword.Text = row.Cells[6].Value.ToString();
                tBFatherName.Text = row.Cells[7].Value.ToString();
                tBFPhone.Text = row.Cells[8].Value.ToString();
                mTBFCNIC.Text = row.Cells[9].Value.ToString();
                fcnic = row.Cells[9].Value.ToString();
            }
        }
    }
}