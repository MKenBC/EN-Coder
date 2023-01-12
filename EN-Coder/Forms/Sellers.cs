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
using EN_Coder.Forms.Home;
using System.Runtime.InteropServices;
using DGVPrinterHelper;

namespace EN_Coder.Forms
{
    public partial class Sellers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public string myName;
        public Sellers()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date <= dateTo.Value.Date)
            {
                int n = 0;
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM encode_table WHERE Date BETWEEN @date1 AND @date2 AND Resellers_Name = @Resellers_Name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Resellers_Name", lbName.Text);
                cmd.Parameters.AddWithValue("@date1", dateFrom.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@date2", dateTo.Value.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader myReader;
                try
                {
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        n += myReader.GetInt32(8);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                tbTotalIncome.Text = n.ToString();

                dgResellersIncome.DataSource = dt;

                dgResellersIncome.AutoGenerateColumns = false;
                dgResellersIncome.AllowUserToAddRows = false;
                dgResellersIncome.AllowDrop = false;
                dgResellersIncome.ReadOnly = true;

                dgResellersIncome.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgResellersIncome.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                con.Close();
                btnExport.Enabled = true;
            }
            else
            {
                MessageBox.Show("Date FROM must be less than Date TO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            lbName.Text = myName;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date <= dateTo.Value.Date)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = lbName.Text.ToString() + " Table";

                for (int i = 1; i < dgResellersIncome.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = dgResellersIncome.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgResellersIncome.Rows.Count; i++)
                {
                    for (int j = 0; j < dgResellersIncome.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgResellersIncome.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialogue = new SaveFileDialog();
                saveFileDialogue.FileName = "Resellers Income";
                saveFileDialogue.DefaultExt = ".xlsx";
                if (saveFileDialogue.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialogue.FileName, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                MessageBox.Show("Data Table Exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                app.Quit();
            }
        }

        //Drag Form ADD using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Sellers_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Question", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Resellers";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgResellersIncome);
        }
    }
}
