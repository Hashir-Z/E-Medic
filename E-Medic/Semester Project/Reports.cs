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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Tables;
using System.IO;


namespace Semester_Project
{
    public partial class Reports : Form
    {
        // Gillani
        //string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        // Hashir
        string connetionString = "Data Source=XTREME-ADDICT\\MYSQL;Initial Catalog=EMedic; Trusted_Connection=true";

        string workingDir = Environment.CurrentDirectory;

        int i = 0;
        string report_name = "";
        string report_result = "";
        int pID;
        public Reports(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadAllReports();
            if (DGVReports.RowCount != 0)
            {
                DGVReports.Rows[0].Selected = true;
            }
            UpdateSelectedCell();
        }

        public string FindName(string name)
        {
            i++;
            string increment = Convert.ToString(i);
            name = string.Concat(name, increment);

            if (File.Exists(workingDir + name + ".pdf"))
            {
                FindName(name);
            }
            return name;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            DGVReports.Rows.Clear();

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT Test.tName, pResult.rResult FROM pResult INNER JOIN Test ON pResult.tID = Test.tID WHERE pID='" + pID + "' AND tName LIKE '%" + tBSearch.Text + "%'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVReports.Rows.Add(dataReader.GetString(0), dataReader.GetString(1));
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void Reports_VisibleChanged(object sender, EventArgs e)
        {
            LoadAllReports();
            if (DGVReports.RowCount != 0)
            {
                DGVReports.Rows[0].Selected = true;
            }
        }

        private void DGVReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedCell();
        }

        private void UpdateSelectedCell()
        {
            if (DGVReports.SelectedRows.Count >= 0 && DGVReports.RowCount != 0)
            {
                DataGridViewRow row = this.DGVReports.Rows[DGVReports.CurrentCell.RowIndex];
                report_name = row.Cells[0].Value.ToString();
                report_result = row.Cells[1].Value.ToString();
            }
        }

        private void bGenReports_Click(object sender, EventArgs e)
        {
            string FName = "";

            if ((report_name == "" || report_result == ""))
            {
                MessageBox.Show("Please Select A Report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (report_result == "Pending")
            {
                MessageBox.Show("Please Pay Your Dues To Generate Report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PdfDocument document = new PdfDocument();

                document.PageSettings.Orientation = PdfPageOrientation.Landscape;
                document.PageSettings.Margins.All = 50;

                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;

                PdfImage image = PdfImage.FromFile(workingDir + "\\yolo.png");
                RectangleF bounds = new RectangleF(176, 0, 390, 130);

                page.Graphics.DrawImage(image, bounds);

                PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                bounds = new RectangleF(0, bounds.Bottom + 90, graphics.ClientSize.Width, 30);

                graphics.DrawRectangle(solidBrush, bounds);

                PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);

                PdfTextElement element = new PdfTextElement("Report Information", subHeadingFont);
                element.Brush = PdfBrushes.White;

                PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");

                SizeF textSize = subHeadingFont.MeasureString(currentDate);
                PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);

                graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
                PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);
                element = new PdfTextElement("   Patient Name                                                  Report Name                                                   Report Result                                                   Payment", timesRoman);
                element.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
                result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));
                PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
                PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
                PointF endPoint = new PointF(graphics.ClientSize.Width, result.Bounds.Bottom + 3);

                graphics.DrawLine(linePen, startPoint, endPoint);

                DataTable ReportDetails = new DataTable();

                PdfLightTable pdflightTable = new PdfLightTable();

                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword from Patient where Patient.pID='" + pID + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                string name = "";
                while (dataReader.Read())
                {
                    name = dataReader.GetString(0);
                }
                int payment = 0;
                if (report_name == "HIV")
                {
                    payment = 5000;
                }

                if (report_name == "Malaria")
                {
                    payment = 500;
                }
                if (report_name == "Corona")
                {
                    payment = 7000;
                }
                if (report_name == "Diabetes")
                {
                    payment = 50000;
                }
                if (report_name == "Hepatitis")
                {
                    payment = 7500;
                }
                if (report_name == "Lung Cancer")
                {
                    payment = 10000;
                }

                string pay = string.Concat(Convert.ToString(payment), " PKR");

                ReportDetails.Columns.Add("Name");
                ReportDetails.Columns.Add("Report Name");
                ReportDetails.Columns.Add("Report Result");
                ReportDetails.Columns.Add("Payment");
                ReportDetails.Rows.Add(new string[] { name, report_name, report_result, pay });

                pdflightTable.DataSource = ReportDetails;

                //Creates the grid cell styles
                PdfLightTableStyle style = new PdfLightTableStyle();
                style.CellPadding = 15;
                style.CellSpacing = 5;
                pdflightTable.Style.CellPadding = 10;
                pdflightTable.Style.CellSpacing = 5;
                //PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                //cellStyle.Borders.All = PdfPens.White;
                //PdfGridRow header = grid.Headers[0];

                pdflightTable.Draw(page, new PointF(10, result.Bounds.Top + 17));

                if (File.Exists(workingDir + "\\HIV.pdf"))
                {
                    FName = FindName(report_name);
                }
                else if (File.Exists(workingDir + "\\Corona.pdf"))
                {
                    FName = FindName(report_name);
                }
                else if (File.Exists(workingDir + "\\LungCancer.pdf"))
                {
                    FName = FindName(report_name);
                }
                else if (File.Exists(workingDir + "\\Diabetes.pdf"))
                {
                    FName = FindName(report_name);
                }
                else if (File.Exists(workingDir + "\\Malaria.pdf"))
                {
                    FName = FindName(report_name);
                }
                else if (File.Exists(workingDir + "\\Hepatitis.pdf"))
                {
                    FName = FindName(report_name);
                }
                else
                {
                    FName = report_name;
                }
                document.Save(FName + ".pdf");
                document.Close(true);
            }
            MessageBox.Show("Report Successfully Generated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(FName + ".pdf");
        }

        private void LoadAllReports()
        {
            DGVReports.Rows.Clear();
            DGVReports.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT Test.tName, pResult.rResult FROM pResult INNER JOIN Test ON pResult.tID = Test.tID WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVReports.Rows.Add(dataReader.GetString(0), dataReader.GetString(1));
            }
        }
    }
}
