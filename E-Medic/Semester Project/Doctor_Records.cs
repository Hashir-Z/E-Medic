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
    public partial class Doctor_Records : Form
    {
        int pID;
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        SqlConnection cnn;
        SqlCommand cmd;

        public Doctor_Records(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Doctor_Records_Load(object sender, EventArgs e)
        {
            UpdateDGV();
            if (DGVDoctors.RowCount != 0)
            {
                DGVDoctors.Rows[0].Selected = true;
            }
            LoadFields();
        }

        private void cBSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string item = "";

            if (cBSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Please Select An Option From The \"Search By\" Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                item = cBSearchBy.SelectedItem.ToString();
                DGVDoctors.Rows.Clear();
            }

            string data = tBSearch.Text;
            if (item == "Name")
            {
                string s = "SELECT dID, dName, dSpeciality, dHome, dSalary FROM Doctor WHERE dIsDeleted!='Yes' AND dName LIKE '" + '%' + data + '%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetValue(4));
                }
            }
            if (item == "Speciality")
            {
                string s = "SELECT dID, dName, dSpeciality, dHome, dSalary FROM Doctor WHERE dIsDeleted!='Yes' AND dSpeciality LIKE '" + '%' + data + '%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetValue(4));
                }
            }
            if (item == "Salary")
            {
                string s = "SELECT dID, dName, dSpeciality, dHome, dSalary FROM Doctor WHERE dIsDeleted!='Yes' AND dSalary LIKE '" + '%' + data + '%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetValue(4));
                }
            }
            cnn.Close();
            LoadFields();
        }

        private void DGVDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string isHomeDoc = "";
            if (rBYes.Checked)
            {
                isHomeDoc = "Yes";
            }
            else
            {
                isHomeDoc = "No";
            }

            string sql = "UPDATE Doctor SET " +
            "dName='" + tBName.Text + "', " +
            "dHome='" + isHomeDoc + "', " +
            "dSpeciality='" + tBSpecialty.Text + "', " +
            "dSalary='" + tBSalary.Text + "' " +
            "WHERE dID='" + this.DGVDoctors.Rows[DGVDoctors.CurrentCell.RowIndex].Cells[0].Value + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Updated Successfully!!");
            UpdateDGV();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "UPDATE Doctor SET dIsDeleted='Yes' WHERE dID='" + this.DGVDoctors.Rows[DGVDoctors.CurrentCell.RowIndex].Cells[0].Value + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Doctor Deleted Successfully!!");
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            DGVDoctors.Rows.Clear();
            DGVDoctors.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Doctor Data
            string sql = "SELECT dID, dName, dSpeciality, dHome, dSalary FROM Doctor WHERE dIsDeleted!='Yes'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVDoctors.Rows.Add(dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetValue(4));
            }
        }

        private void LoadFields()
        {
            if (DGVDoctors.SelectedRows.Count >= 0 && DGVDoctors.RowCount != 0)
            {
                DataGridViewRow row = this.DGVDoctors.Rows[DGVDoctors.CurrentCell.RowIndex];

                tBName.Text = row.Cells[1].Value.ToString();
                tBSpecialty.Text = row.Cells[2].Value.ToString();
                tBSalary.Text = row.Cells[4].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Yes")
                {
                    rBYes.Checked = true;
                }
                else
                {
                    rBNo.Checked = true;
                }
            }
        }

    }
}