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
    public partial class Appointment_Records : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        SqlConnection cnn;
        SqlCommand cmd;
        int aID;
        int pID;
        string AppointmentStatus = "";
        string Payment = "";

        public Appointment_Records(int pid)
        {
            InitializeComponent();
            this.pID = pid;
        }

        private void Appointment_Records_Load(object sender, EventArgs e)
        {
            UpdateDGV();
            if (DGVAppRec.RowCount != 0)
            {
                DGVAppRec.Rows[0].Selected = true;
            }
            LoadFields();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (cBSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Please Select An Option From \"Search By\" Box! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DGVAppRec.Rows.Clear();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string item = cBSearchBy.SelectedItem.ToString();
                string txt = tBSearch.Text;
                if (item == "Any")
                {
                    // Load Patient Appointments
                    string sql = "Select dAppointment.aID, Patient.pName, Doctor.dName, Doctor.dSpeciality, dAppointment.aDate, dAppointment.timeSlot, dAppointment.Payment, dAppointment.AppointmentStatus, dAppointment.AppointmentPlace from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID";
                    cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVAppRec.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8));
                    }
                }
                if (item == "Doctor Name")
                {

                    if (tBSearch.Text == "")
                    {
                        MessageBox.Show("Please Type Doctor Name Into The Search Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DGVAppRec.Rows.Clear();

                        // Load Search Results
                        string sql = "Select dAppointment.aID, Patient.pName, Doctor.dName, Doctor.dSpeciality, dAppointment.aDate, dAppointment.timeSlot, dAppointment.Payment, dAppointment.AppointmentStatus, dAppointment.AppointmentPlace from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and Doctor.dName LIKE '" + '%' + tBSearch.Text + '%' + "'";
                        cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            DGVAppRec.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8));
                        }
                    }
                }
                if (item == "Patient Name")
                {
                    if (tBSearch.Text == "")
                    {
                        MessageBox.Show("Please Type Patient's Name Into The Search Bar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DGVAppRec.Rows.Clear();
                        // Load Patient Reports
                        string sql = "Select dAppointment.aID, Patient.pName, Doctor.dName, Doctor.dSpeciality, dAppointment.aDate, dAppointment.timeSlot, dAppointment.Payment, dAppointment.AppointmentStatus, dAppointment.AppointmentPlace from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and Patient.pName LIKE '" + '%' + tBSearch.Text + '%' + "'";
                        cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            DGVAppRec.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8));
                        }
                    }
                }
                cnn.Close();
                LoadFields();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

            if (AppointmentStatus == "")
            {
                MessageBox.Show("Please Select An Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cBNotPaid.Checked == true && cBPaid.Checked == true)
            {
                MessageBox.Show("Please Select One Payment Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cBNotPaid.Checked == false && cBPaid.Checked == false)
            {
                MessageBox.Show("Please Select One Payment Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rBTime2.Checked == false && rBTime4.Checked == false && rBTime6.Checked == false && rBTime8.Checked == false)
            {
                MessageBox.Show("Please Select Time Slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string TimeSlot = "";
            if (rBTime2.Checked == true)
            {
                TimeSlot = "14:00";
            }
            if (rBTime4.Checked == true)
            {
                TimeSlot = "16:00";
            }
            if (rBTime6.Checked == true)
            {
                TimeSlot = "18:00";
            }
            if (rBTime8.Checked == true)
            {
                TimeSlot = "20:00";
            }

            string AppStatus = "";
            string AppPlace = "";
            string PayStatus = "";

            if (cBCancelled.Checked == true)
            {
                AppStatus = "Cancelled";
            }
            if (cBCancelled.Checked == false)
            {
                AppStatus = "Not Cancelled";
            }

            if (cBPaid.Checked == true)
            {
                PayStatus = "Paid";
            }
            if (cBNotPaid.Checked == true)
            {
                PayStatus = "Pending";
            }

            if (cBAtHome.Checked)
            {
                AppPlace = "Home";
            }
            else
            {
                AppPlace = "Hospital";
            }

            // Create Appointment
            string sql = "Update dAppointment Set aDate='" + DTPDate.Value.ToString("dd/MM/yy") + "', " +
                "timeSlot='" + TimeSlot + "', " + 
                "Payment='" + PayStatus + "', " + 
                "AppointmentStatus='" + AppStatus + "', " + 
                "AppointmentPlace='" + AppPlace + "'" + 
                "Where aID='" + aID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            MessageBox.Show("Appointment Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateDGV();
            LoadFields();
        }

        private void DGVPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields();
        }

        private void cBNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (cBNotPaid.Checked)
            {
                cBPaid.Checked = false;
            }
        }

        private void cBPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPaid.Checked)
            {
                cBNotPaid.Checked = false;
            }
        }

        private void rBTime2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTime2.Checked)
            {
                rBTime2.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rBTime2.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            }
        }

        private void rBTime4_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTime4.Checked)
            {
                rBTime4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rBTime4.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            }
        }

        private void rBTime6_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTime6.Checked)
            {
                rBTime6.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rBTime6.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            }
        }

        private void rBTime8_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTime8.Checked)
            {
                rBTime8.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rBTime8.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            }
        }

        private void UpdateDGV()
        {
            DGVAppRec.Rows.Clear();
            DGVAppRec.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Doctor Data
            string sql = "Select dAppointment.aID, Patient.pName, Doctor.dName, Doctor.dSpeciality, dAppointment.aDate, dAppointment.timeSlot, dAppointment.Payment, dAppointment.AppointmentStatus, dAppointment.AppointmentPlace from dAppointment, Doctor, Patient where Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVAppRec.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8));
            }
        }

        private void LoadFields()
        {
            if (DGVAppRec.SelectedRows.Count >= 0 && DGVAppRec.RowCount != 0)
            {
                DataGridViewRow row = this.DGVAppRec.Rows[DGVAppRec.CurrentCell.RowIndex];
                string aID1 = row.Cells[0].Value.ToString();
                aID = Convert.ToInt32(aID1);
                DTPDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                Payment = row.Cells[6].Value.ToString();
                AppointmentStatus = row.Cells[7].Value.ToString();
                string TimeSlot = row.Cells[5].Value.ToString();
                string AppPlace = row.Cells[8].Value.ToString();

                if (Payment == "Pending")
                {
                    cBNotPaid.Checked = true;
                }
                else
                {
                    cBPaid.Checked = true;
                }

                if (AppointmentStatus == "Cancelled")
                {
                    cBCancelled.Checked = true;
                }
                else
                {
                    cBCancelled.Checked = false;
                }

                if (TimeSlot == "14:00")
                {
                    rBTime2.Checked = true;
                }
                else if (TimeSlot == "16:00")
                {
                    rBTime4.Checked = true;
                }
                else if (TimeSlot == "18:00")
                {
                    rBTime6.Checked = true;
                }
                else if (TimeSlot == "20:00")
                {
                    rBTime8.Checked = true;
                }
                if (AppPlace == "Home")
                {
                    cBAtHome.Checked = true;
                }
                else
                {
                    cBAtHome.Checked = false;
                }
            }
        }
    }
}