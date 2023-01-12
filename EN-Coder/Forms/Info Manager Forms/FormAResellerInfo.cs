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
using DGVPrinterHelper;

namespace EN_Coder.Forms.Info_Manager_Forms
{
    public partial class FormAResellerInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormAResellerInfo()
        {
            InitializeComponent();
        }

        private void FillDataGrid()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM resellers_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgResellersInfo.DataSource = dt;

            dgResellersInfo.AutoGenerateColumns = false;
            dgResellersInfo.AllowUserToAddRows = false;
            dgResellersInfo.AllowDrop = false;
            dgResellersInfo.ReadOnly = true;

            dgResellersInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgResellersInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgResellersInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgResellersInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgResellersInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void ClearTextboxes()
        {
            tbRID.Text = "Resellers ID";
            tbRID.ForeColor = Color.Gray;

            tbRName.Text = "Resellers Name";
            tbRName.ForeColor = Color.Gray;

            tbRDescription.Text = "Description";
            tbRDescription.ForeColor = Color.Gray;

            tbRContact.Text = "Contact";
            tbRContact.ForeColor = Color.Gray;

            tbRPlatform.Text = "Income Platform";
            tbRPlatform.ForeColor = Color.Gray;

            btnRAdd.Enabled = true;
            btnRUpdate.Enabled = false;
            btnRDelete.Enabled = false;
            tbRID.Enabled = true;
        }

        #region Textbox Mouse Click Event
        private void tbRID_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRID.Text == "Resellers ID")
            {
                tbRID.Clear();
                tbRID.Focus();
                tbRID.ForeColor = Color.Black;
            }

            if (tbRName.TextLength == 0)
            {
                tbRName.Text = "Resellers Name";
                tbRName.ForeColor = Color.Gray;
            }

            if (tbRDescription.TextLength == 0)
            {
                tbRDescription.Text = "Description";
                tbRDescription.ForeColor = Color.Gray;
            }

            if (tbRContact.TextLength == 0)
            {
                tbRContact.Text = "Contact";
                tbRContact.ForeColor = Color.Gray;
            }

            if (tbRPlatform.TextLength == 0)
            {
                tbRPlatform.Text = "Income Platform";
                tbRPlatform.ForeColor = Color.Gray;
            }
        }

        private void tbRName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRName.Text == "Resellers Name")
            {
                tbRName.Clear();
                tbRName.Focus();
                tbRName.ForeColor = Color.Black;
            }

            if (tbRDescription.TextLength == 0)
            {
                tbRDescription.Text = "Description";
                tbRDescription.ForeColor = Color.Gray;
            }

            if (tbRContact.TextLength == 0)
            {
                tbRContact.Text = "Contact";
                tbRContact.ForeColor = Color.Gray;
            }

            if (tbRPlatform.TextLength == 0)
            {
                tbRPlatform.Text = "Income Platform";
                tbRPlatform.ForeColor = Color.Gray;
            }

            if (tbRID.TextLength == 0)
            {
                tbRID.Text = "Resellers ID";
                tbRID.ForeColor = Color.Gray;
            }
        }

        private void tbRDescription_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRDescription.Text == "Description")
            {
                tbRDescription.Clear();
                tbRDescription.Focus();
                tbRDescription.ForeColor = Color.Black;
            }

            if (tbRName.TextLength == 0)
            {
                tbRName.Text = "Resellers Name";
                tbRName.ForeColor = Color.Gray;
            }

            if (tbRContact.TextLength == 0)
            {
                tbRContact.Text = "Contact";
                tbRContact.ForeColor = Color.Gray;
            }

            if (tbRPlatform.TextLength == 0)
            {
                tbRPlatform.Text = "Income Platform";
                tbRPlatform.ForeColor = Color.Gray;
            }

            if (tbRID.TextLength == 0)
            {
                tbRID.Text = "Resellers ID";
                tbRID.ForeColor = Color.Gray;
            }
        }

        private void tbRContact_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRContact.Text == "Contact")
            {
                tbRContact.Clear();
                tbRContact.Focus();
                tbRContact.ForeColor = Color.Black;
            }

            if (tbRName.TextLength == 0)
            {
                tbRName.Text = "Resellers Name";
                tbRName.ForeColor = Color.Gray;
            }

            if (tbRDescription.TextLength == 0)
            {
                tbRDescription.Text = "Description";
                tbRDescription.ForeColor = Color.Gray;
            }

            if (tbRPlatform.TextLength == 0)
            {
                tbRPlatform.Text = "Income Platform";
                tbRPlatform.ForeColor = Color.Gray;
            }

            if (tbRID.TextLength == 0)
            {
                tbRID.Text = "Resellers ID";
                tbRID.ForeColor = Color.Gray;
            }
        }

        private void tbRPlatform_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRPlatform.Text == "Income Platform")
            {
                tbRPlatform.Clear();
                tbRPlatform.Focus();
                tbRPlatform.ForeColor = Color.Black;
            }

            if (tbRName.TextLength == 0)
            {
                tbRName.Text = "Resellers Name";
                tbRName.ForeColor = Color.Gray;
            }

            if (tbRDescription.TextLength == 0)
            {
                tbRDescription.Text = "Description";
                tbRDescription.ForeColor = Color.Gray;
            }

            if (tbRContact.TextLength == 0)
            {
                tbRContact.Text = "Contact";
                tbRContact.ForeColor = Color.Gray;
            }

            if (tbRID.TextLength == 0)
            {
                tbRID.Text = "Resellers ID";
                tbRID.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void FormAResellerInfo_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            if ((tbRID.Text != "Resellers ID") && (tbRName.Text != "Resellers Name") && (tbRContact.Text != "Contact")
                && (tbRPlatform.Text != "Income Platform") && (tbRDescription.Text != "Description"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO resellers_info(Resellers_ID, Resellers_Name, Contact, Income_Platform, Description)" +
                        " VALUES (@Resellers_ID, @Resellers_Name, @Contact, @Income_Platform, @Description)", con);

                    cmd.Parameters.AddWithValue("@Resellers_ID", int.Parse(tbRID.Text)); ;
                    cmd.Parameters.AddWithValue("@Resellers_Name", tbRName.Text);
                    cmd.Parameters.AddWithValue("@Contact", tbRContact.Text);
                    cmd.Parameters.AddWithValue("@Income_Platform", tbRPlatform.Text);
                    cmd.Parameters.AddWithValue("@Description", tbRDescription.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextboxes();
                    FillDataGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Input Different Resellers ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRID.Text = "Resellers ID";
                    tbRID.ForeColor = Color.Gray;
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            if ((tbRName.Text != "Resellers Name") && (tbRContact.Text != "Contact")
               && (tbRPlatform.Text != "Income Platform") && (tbRDescription.Text != "Description"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE resellers_info SET Resellers_ID = @Resellers_ID" +
                        ", Resellers_Name = @Resellers_Name, Contact = @Contact, Income_Platform = @Income_Platform" +
                        ", Description = @Description WHERE Resellers_ID = @Resellers_ID", con);

                    cmd.Parameters.AddWithValue("@Resellers_ID", int.Parse(tbRID.Text));
                    cmd.Parameters.AddWithValue("@Resellers_Name", tbRName.Text);
                    cmd.Parameters.AddWithValue("@Contact", tbRContact.Text);
                    cmd.Parameters.AddWithValue("@Income_Platform", tbRPlatform.Text);
                    cmd.Parameters.AddWithValue("@Description", tbRDescription.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextboxes();
                    FillDataGrid();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRDelete_Click(object sender, EventArgs e)
        {
            if (tbRID.Text != "Resellers ID")
            {
                try
                {
                    if (MessageBox.Show("Do you want to Delete " + tbRName.Text + "'s Information?", "Question",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM resellers_info WHERE Resellers_ID = @Resellers_ID", con);

                        cmd.Parameters.AddWithValue("@Resellers_ID", int.Parse(tbRID.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearTextboxes();
                        FillDataGrid();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the information to be deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRClear_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }

        private void tbRID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgResellersInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                tbRID.Text = dgResellersInfo.CurrentRow.Cells[0].Value.ToString();
                tbRName.Text = dgResellersInfo.CurrentRow.Cells[1].Value.ToString();
                tbRContact.Text = dgResellersInfo.CurrentRow.Cells[2].Value.ToString();
                tbRPlatform.Text = dgResellersInfo.CurrentRow.Cells[3].Value.ToString();
                tbRDescription.Text = dgResellersInfo.CurrentRow.Cells[4].Value.ToString();

                tbRID.ForeColor = Color.Black;
                tbRName.ForeColor = Color.Black;
                tbRContact.ForeColor = Color.Black;
                tbRPlatform.ForeColor = Color.Black;
                tbRDescription.ForeColor = Color.Black;

                btnRAdd.Enabled = false;
                btnRUpdate.Enabled = true;
                btnRDelete.Enabled = true;
                tbRID.Enabled = false;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Resellers Table";

            for (int i = 1; i < dgResellersInfo.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dgResellersInfo.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgResellersInfo.Rows.Count; i++)
            {
                for (int j = 0; j < dgResellersInfo.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgResellersInfo.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Resellers Informations";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Resellers Information";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgResellersInfo);
        }
    }
}
