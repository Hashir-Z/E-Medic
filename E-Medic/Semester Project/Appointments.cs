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
    public partial class Appointments : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        int pID;
        public Appointments(int pID)
        {
            InitializeComponent();
            this.pID = pID;
            DTPDate.Value = DateTime.Now;
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadDocData();
            if (DGVDoctors.RowCount != 0)
            {
                DGVDoctors.Rows[0].Selected = true;
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            LoadDocData();
            tBSearch.Text = "";
            cBCardiologist.Checked = false;
            cBNephro.Checked = false;
            cBNeuro.Checked = false;
            cBPediatric.Checked = false;
            cBPsychiatric.Checked = false;
            rBTime2.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            rBTime4.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            rBTime6.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            rBTime8.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            rBTime2.Checked = false;
            rBTime4.Checked = false;
            rBTime6.Checked = false;
            rBTime8.Checked = false;
            cBAvailNo.Checked = false;
            cBAvailYes.Checked = false;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text == "")
            {
                MessageBox.Show("Please Enter Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DGVDoctors.Rows.Clear();
            DGVDoctors.Refresh();
            string Query = "";
            bool Run = false;
            if (cBCardiologist.Checked)
            {
                if (Run)
                {
                    Query += " OR ";
                }
                Query += "dSpeciality='Cardiologist'";
                Run = true;
            }
            if (cBNephro.Checked)
            {
                if (Run)
                {
                    Query += " OR ";
                }
                Query += "dSpeciality='Nephrologist'";
                Run = true;

            }
            if (cBNeuro.Checked)
            {
                if (Run)
                {
                    Query += " OR ";
                }
                Query += "dSpeciality='Neurologist'";
                Run = true;
            }
            if (cBPediatric.Checked)
            {
                if (Run)
                {
                    Query += " OR ";
                }
                Query += "dSpeciality='Pediatric'";
                Run = true;
            }
            if (cBPsychiatric.Checked)
            {
                if (Run)
                {
                    Query += " OR ";
                }
                Query += "dSpeciality='Psychiatric'";
                Run = true;
            }

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string sql;
            if (Run)
            {
                sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes' AND dName LIKE '%" + tBSearch.Text + "%' AND (" + Query + ")";
            }
            else
            {
                sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes' AND dName LIKE '%" + tBSearch.Text + "%'";
            }
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(3), dataReader.GetString(2), dataReader.GetInt32(4));
            }
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            string home = "";
            if (cBAvailNo.Checked)
            {
                home = "No";
            }
            if (cBAvailYes.Checked)
            {
                home = "Yes";
            }

            string Speciality1 = "";
            string Speciality2 = "";
            string Speciality3 = "";
            string Speciality4 = "";
            string Speciality5 = "";

            if (cBCardiologist.Checked)
            {
                Speciality1 = "Cardiologist";
            }
            if (cBNephro.Checked)
            {
                Speciality2 = "Nephrologist";
            }
            if (cBNeuro.Checked)
            {
                Speciality3 = "Neurologist";
            }
            if (cBPediatric.Checked)
            {
                Speciality4 = "Pediatric";
            }
            if (cBPsychiatric.Checked)
            {
                Speciality5 = "Psychiatric";
            }

            if (Speciality1 == "" && Speciality2 == "" && Speciality3 == "" && Speciality4 == "" && Speciality5 == "" && home == "")
            {
                MessageBox.Show("Please Apply At Least 1 Filter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DGVDoctors.Rows.Clear();
            DGVDoctors.Refresh();

            if (home == "")
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes' AND dSpeciality='" + Speciality1 + "' or dSpeciality='" + Speciality2 + "' or dSpeciality='" + Speciality3 + "' or dSpeciality='" + Speciality4 + "' or dSpeciality='" + Speciality5 + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(3), dataReader.GetString(2), String.Format("{0:n0}", dataReader.GetInt32(4)));
                }
            }
            else if (home != "" && Speciality1 == "" && Speciality2 == "" && Speciality3 == "" && Speciality4 == "" && Speciality5 == "")
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes' AND dHome='" + home + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(3), dataReader.GetString(2), String.Format("{0:n0}", dataReader.GetInt32(4)));
                }
            }
            else if ((home != "") && (Speciality1 != "" || Speciality2 != "" || Speciality3 != "" || Speciality4 != "" || Speciality5 != ""))
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes' AND (dSpeciality='" + Speciality1 + "' or dSpeciality='" + Speciality2 + "' or dSpeciality='" + Speciality3 + "' or dSpeciality='" + Speciality4 + "' or dSpeciality='" + Speciality5 + "') and (dHome='" + home + "')";

                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(3), dataReader.GetString(2), String.Format("{0:n0}", dataReader.GetInt32(4)));
                }
            }
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            int dID;
            string Name;
            string AppPlace = "";

            if (DGVDoctors.SelectedCells.Count > 0)
            {
                dID = Convert.ToInt32(DGVDoctors.Rows[DGVDoctors.SelectedCells[0].RowIndex].Cells["dID"].Value.ToString());
                Name = DGVDoctors.Rows[DGVDoctors.SelectedCells[0].RowIndex].Cells["DocName"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Doctor To Book Appointment With!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cBAtHome.Checked)
            {
                AppPlace = "Home";
            }
            else
            {
                AppPlace = "Hospital";
            }
            string timeslot = "";
            if (rBTime2.Checked == true)
            {
                timeslot = "14:00";
                DTPDate.Value = DateTime.Today.AddHours(14);
            }
            if (rBTime4.Checked == true)
            {
                timeslot = "16:00";
                DTPDate.Value = DateTime.Today.AddHours(16);
            }
            if (rBTime6.Checked == true)
            {
                timeslot = "18:00";
                DTPDate.Value = DateTime.Today.AddHours(18);
            }
            if (rBTime8.Checked == true)
            {
                timeslot = "20:00";
                DTPDate.Value = DateTime.Today.AddHours(20);
            }
            if (AppPlace == "No" && cBAtHome.Checked == true)
            {
                MessageBox.Show("This Doctor Is Not Available For Home Visit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timeslot == "")
            {
                MessageBox.Show("Select A Time Slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DTPDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Appointment Date Cannot Be In The Past!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create Appointment
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string sql = "SELECT aDate, timeSlot, dID FROM dAppointment WHERE aDate='" + DTPDate.Value.ToString("dd/MM/yy") + "' and timeSlot='" + timeslot + "' and dID='" + dID + "'";

            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            string date = DTPDate.Value.ToString("dd/MM/yy");
            while (dataReader.Read())
            {
                if (dataReader.GetString(0) == date && dataReader.GetString(1) == timeslot && dataReader.GetInt32(2) == dID)
                {
                    MessageBox.Show("The Doctor Is Busy On The Date & Time Slot You Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            cnn.Close();

            SqlConnection cnn1 = new SqlConnection(connetionString);
            cnn1.Open();
            string sql1 = "INSERT INTO dAppointment(aDate, timeSlot, AppointmentPlace, dID, pID) VALUES('" + DTPDate.Value.ToString("dd/MM/yy") + "', '" + timeslot + "', '" + AppPlace + "', '" + dID + "', '" + pID + "')";
            SqlCommand command1 = new SqlCommand(sql1, cnn1);
            command1.ExecuteNonQuery();

            MessageBox.Show("Appointment With Dr." + Name + " Scheduled For " + DTPDate.Value.ToString("dd/MM/yy") + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cBAvailYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAvailYes.Checked)
            {
                cBAvailNo.Checked = false;
            }
        }

        private void cBAvailNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAvailNo.Checked)
            {
                cBAvailYes.Checked = false;
            }
        }

        private void LoadDocData()
        {
            DGVDoctors.Rows.Clear();
            DGVDoctors.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Doctor Data
            string sql = "SELECT * FROM Doctor WHERE dIsDeleted!='Yes'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(3), dataReader.GetString(2), String.Format("{0:n0}", dataReader.GetInt32(4)));
            }
        }
    }
}