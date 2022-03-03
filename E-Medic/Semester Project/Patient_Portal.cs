using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class Patient_Portal : Form
    {
        // Hashir
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        int pID;
        ProfileInfo ProfileInfoObj;
        Reports ReportsObj;
        Appointments AppointmentsObj;
        Tests TestsObj;
        Payment PaymentObj;
        AppointmentDetails AppointmentdetailsObj;
        Dashboard DashboardObj;

        public Patient_Portal(int pID)
        {
            InitializeComponent();
            this.pID = pID;

            ProfileInfoObj = new ProfileInfo(pID, this) { TopLevel = false, TopMost = true };
            ReportsObj = new Reports(pID) { TopLevel = false, TopMost = true };
            AppointmentsObj = new Appointments(pID) { TopLevel = false, TopMost = true };
            TestsObj = new Tests(pID) { TopLevel = false, TopMost = true };
            PaymentObj = new Payment(pID) { TopLevel = false, TopMost = true };
            AppointmentdetailsObj = new AppointmentDetails(pID) { TopLevel = false, TopMost = true };
            DashboardObj = new Dashboard(pID) { TopLevel = false, TopMost = true };

            this.pFormArea.Controls.Add(ProfileInfoObj);
            this.pFormArea.Controls.Add(ReportsObj);
            this.pFormArea.Controls.Add(AppointmentsObj);
            this.pFormArea.Controls.Add(TestsObj);
            this.pFormArea.Controls.Add(PaymentObj);
            this.pFormArea.Controls.Add(AppointmentdetailsObj);
            this.pFormArea.Controls.Add(DashboardObj);
        }

        private void Patient_Portal_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            pDashboardActive.Show();
            DashboardObj.Show();

            LoadDetails();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pDashboardActive.Show();

           DashboardObj.Show();
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pBloodTestActive.Show();

            TestsObj.Show();
        }

        private void bReports_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pReportActive.Show();

            ReportsObj.Show();
        }

        private void bPayments_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pPaymentActive.Show();

            PaymentObj.Show();
        }

        private void bAppointment_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pAppointmentActive.Show();

            AppointmentsObj.Show();
        }

        private void bAppRecords_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pAppRecordsActive.Show();

            AppointmentdetailsObj.Show();
        }

        private void bProfileInfo_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pProfileInfoActive.Show();

            ProfileInfoObj.Show();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Start s3 = new Start();
            s3.Show();
        }

        private void bClose_MouseEnter(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.Red;
        }

        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s2 = new Start();
            s2.Show();
            this.Close();
        }

        private void bMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HideAllPanels()
        {
            // Hide Blue "Active" indicator panel
            pDashboardActive.Hide();
            pReportActive.Hide();
            pAppointmentActive.Hide();
            pBloodTestActive.Hide();
            pPaymentActive.Hide();
            pAppRecordsActive.Hide();
            pProfileInfoActive.Hide();

            // Hide All Forms
            ProfileInfoObj.Hide();
            ReportsObj.Hide();
            AppointmentsObj.Hide();
            TestsObj.Hide();
            PaymentObj.Hide();
            AppointmentdetailsObj.Hide();
            DashboardObj.Hide();
        }

        private void LoadDetails()
        {
            SqlConnection cnn;
            SqlCommand command;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            // Get Patient Data

            string sql = "SELECT pName, pAge FROM Patient WHERE pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lUsername.Text = dataReader.GetString(0);
                lAge.Text += Convert.ToString(dataReader.GetInt32(1));
            }

            lWelcome.Text = lWelcome.Text + " " + lUsername.Text;

        }
    }
}
