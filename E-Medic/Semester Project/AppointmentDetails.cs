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
    public partial class AppointmentDetails : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        int aID = 0;
        int pID;
        string status = "";
        public AppointmentDetails(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void AppointmentDetails_Load(object sender, EventArgs e)
        {
            LoadAllAppointmentDetail();
        }

        private void AppointmentDetails_VisibleChanged(object sender, EventArgs e)
        {
            LoadAllAppointmentDetail();
            if (DGVAppointments.RowCount != 0)
            {
                DGVAppointments.Rows[0].Selected = true;
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (status == "Cancelled")
            {
                MessageBox.Show("Appointment Already Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (status == "" || aID == 0)
            {
                MessageBox.Show("Please Select an Appointment to Cancel!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DateTime.Parse(this.DGVAppointments.Rows[DGVAppointments.CurrentCell.RowIndex].Cells[3].Value.ToString()) < DateTime.Now)
            {
                MessageBox.Show("Can Not Cancel Appointment From The Past!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DGVAppointments.Rows.Clear();
                DGVAppointments.Refresh();
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();

                // Update Patient Appointment
                string sql = "Update dAppointment Set AppointmentStatus='Cancelled' Where aID='" + aID + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                LoadAllAppointmentDetail();
                MessageBox.Show("Appointment Cancelled Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGVPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVAppointments.Rows[e.RowIndex];
                string aID1 = "";
                aID1 = row.Cells[0].Value.ToString();
                aID = Convert.ToInt32(aID1);
                status = row.Cells[5].Value.ToString();
            }
        }

        private void LoadAllAppointmentDetail()
        {
            DGVAppointments.Rows.Clear();
            DGVAppointments.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "Select dAppointment.aID,Doctor.dName,Doctor.dSpeciality,dAppointment.aDate,dAppointment.timeSlot,dAppointment.Payment,dAppointment.AppointmentStatus,dAppointment.AppointmentPlace from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and dAppointment.pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVAppointments.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7));
            }
        }
    }
}