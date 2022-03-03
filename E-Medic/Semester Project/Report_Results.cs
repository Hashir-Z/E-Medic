using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class Report_Results : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        int pID;
        int PayID;
        public Report_Results(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Report_Results_Load(object sender, EventArgs e)
        {
            UpdateDGV();
            if (DGVReports.RowCount != 0)
            {
                DGVReports.Rows[0].Selected = true;
            }
            LoadFields();
        }

        private void DGVReports_VisibleChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void cBSearchTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string item = "";
            DGVReports.Rows.Clear();
            if (cBSearchTest.SelectedItem == null)
            {
                MessageBox.Show("Please Select An Option From The \"Search By\" Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                item = cBSearchTest.SelectedItem.ToString();
            }

            SqlConnection cnn = new SqlConnection(connetionString);
            if (tBSearch.Text == "")
            {
                cnn.Open();
                if (item == "Any")
                {
                    // Load Patient Reports
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID and Payment.payID=pResult.payID";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Malaria")
                {
                    // Load Patient Reports
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Hepatitis")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Corona")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "HIV")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Diabetes")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Lung Cancer")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
            }
            else if (tBSearch.Text != "" && item == "Any")
            {
                cnn.Open();
                // Load Patient Reports
                string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and Patient.pCNIC='" + tBSearch.Text + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                }

            }
            else if (tBSearch.Text != "" && item != "Any")
            {
                cnn.Open();
                // Load Patient Reports
                string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName='" + cBSearchTest.Text + "' and Patient.pCNIC='" + tBSearch.Text + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                }
            }
            else
            {
                MessageBox.Show("Please Select An Option From The \"Search By\" Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadFields();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string PayStatus = "";
            if (rBNotPaid.Checked == true)
            {
                PayStatus = "Pending";
            }
            if (rBPaid.Checked == true)
            {
                PayStatus = "Paid";
            }
            string tid1 = Convert.ToString(PayID);
            string s = "UPDATE Payment SET " +
            "Payment.payStatus='" + PayStatus + "' " +
            "WHERE Payment.payID='" + tid1 + "'";
            SqlCommand command = new SqlCommand(s, cnn);
            command.ExecuteNonQuery();

            s = "UPDATE pResult SET " +
            "pResult.rResult='" + cBRepResult.Text + "' " +
            "WHERE pResult.payID='" + tid1 + "'";
            SqlCommand command1 = new SqlCommand(s, cnn);
            command1.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Updated Successfully!!");
            UpdateDGV();
        }

        private void DGVReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string payid1 = Convert.ToString(PayID);
            string s = "Delete From pResult WHERE pResult.payID='" + payid1 + "'";

            SqlCommand command = new SqlCommand(s, cnn);
            command.ExecuteNonQuery();

            s = "Delete From Payment WHERE Payment.payID='" + payid1 + "'";
            SqlCommand command1 = new SqlCommand(s, cnn);
            command1.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Deleted Successfully!!");
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            DGVReports.Rows.Clear();
            DGVReports.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Doctor Data
            string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
            }
            if (DGVReports.RowCount != 0)
            {
                DGVReports.Rows[0].Selected = true;
            }
        }

        private void LoadFields()
        {
            if (DGVReports.SelectedRows.Count >= 0 && DGVReports.RowCount != 0)
            {
                DataGridViewRow row = this.DGVReports.Rows[DGVReports.CurrentCell.RowIndex];

                PayID = Convert.ToInt32(row.Cells[0].Value.ToString());

                tBRepName.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Positive")
                {
                    cBRepResult.SelectedIndex = 1;
                }
                else if (row.Cells[3].Value.ToString() == "Negative")
                {
                    cBRepResult.SelectedIndex = 2;
                }
                else
                {
                    cBRepResult.SelectedIndex = 0;
                }

                string PaymentStatus = row.Cells[4].Value.ToString();
                if (PaymentStatus == "Pending")
                {
                    rBNotPaid.Checked = true;
                    rBPaid.Checked = false;
                }
                else
                {
                    rBNotPaid.Checked = false;
                    rBPaid.Checked = true;
                }
            }
        }
    }
}