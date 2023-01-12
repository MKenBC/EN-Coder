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

namespace EN_Coder.Forms
{
    public partial class FormECashMonitor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormECashMonitor()
        {
            InitializeComponent();
        }

        private void FillDataGridIncome()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM cash_income", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCashMonitor.DataSource = dt;

            dgCashMonitor.AutoGenerateColumns = false;
            dgCashMonitor.AllowUserToAddRows = false;
            dgCashMonitor.AllowDrop = false;
            dgCashMonitor.ReadOnly = true;

            dgCashMonitor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgCashMonitor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgCashMonitor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void FillDataGridExpense()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM cash_expense", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCashMonitor.DataSource = dt;

            dgCashMonitor.AutoGenerateColumns = false;
            dgCashMonitor.AllowUserToAddRows = false;
            dgCashMonitor.AllowDrop = false;
            dgCashMonitor.ReadOnly = true;

            dgCashMonitor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgCashMonitor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgCashMonitor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void ClearTextboxes()
        {
            tbAmount.Text = "000";
            tbAmount.ForeColor = Color.Gray;

            tbDetails.Text = "descriptions";
            tbDetails.ForeColor = Color.Gray;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void rbIncome_CheckedChanged(object sender, EventArgs e)
        {
            lbSelected.Text = "Income";
            FillDataGridIncome();
        }

        private void rbExpence_CheckedChanged(object sender, EventArgs e)
        {
            lbSelected.Text = "Expense";
            FillDataGridExpense();
        }

        #region btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbIncome.Checked == true)
            {
                if ((tbAmount.Text != "000") && (tbDetails.Text != "descriptions")
                && (tbAmount.Text != "") && (tbDetails.Text != ""))
                {
                    try
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO cash_income(Date, Amount, Details)" +
                            " VALUES (@Date, @Amount, @Details)", con);

                        cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("@Amount", int.Parse(tbAmount.Text));
                        cmd.Parameters.AddWithValue("@Details", tbDetails.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearTextboxes();
                        FillDataGridIncome();
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
            else if (rbExpence.Checked == true)
            {
                if ((tbAmount.Text != "000") && (tbDetails.Text != "descriptions")
               && (tbAmount.Text != "") && (tbDetails.Text != ""))
                {
                    try
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO cash_expense(Date, Amount, Details)" +
                            " VALUES (@Date, @Amount, @Details)", con);

                        cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("@Amount", int.Parse(tbAmount.Text));
                        cmd.Parameters.AddWithValue("@Details", tbDetails.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearTextboxes();
                        FillDataGridExpense();
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
            else
            {
                MessageBox.Show("Please fill all the Type needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion

        #region MouseClick Event
        private void tbAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbAmount.Text == "000")
            {
                tbAmount.Clear();
                tbAmount.Focus();
                tbAmount.ForeColor = Color.Black;
            }

            if (tbDetails.Text == "")
            {
                tbDetails.ForeColor = Color.Gray;
                tbDetails.Text = "descriptions";
            }
        }

        private void tbDetails_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbDetails.Text == "descriptions")
            {
                tbDetails.Clear();
                tbDetails.Focus();
                tbDetails.ForeColor = Color.Black;
            }

            if (tbAmount.Text == "")
            {
                tbAmount.ForeColor = Color.Gray;
                tbAmount.Text = "000";
            }
        }
        #endregion

        private void dgCashMonitor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dateSet.Value = DateTime.ParseExact(dgCashMonitor.CurrentRow.Cells[0].Value.ToString(),
                "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            tbAmount.Text = dgCashMonitor.CurrentRow.Cells[1].Value.ToString();
            tbDetails.Text = dgCashMonitor.CurrentRow.Cells[2].Value.ToString();
            
            tbAmount.ForeColor = Color.Black;
            tbDetails.ForeColor = Color.Black;

            dateSet.Enabled = false;
            tbAmount.Enabled = false;
            tbDetails.Enabled = false;
            rbIncome.Enabled = false;
            rbExpence.Enabled = false;

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            if (rbIncome.Checked == true)
            {
                FillDataGridIncome();
            }
            else if (rbExpence.Checked == true)
            {
                FillDataGridExpense();
            }

            dateSet.Enabled = true;
            tbAmount.Enabled = true;
            tbDetails.Enabled = true;
            rbIncome.Enabled = true;
            rbExpence.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbIncome.Checked == true)
            {
                if ((tbAmount.Text != "000") && (tbDetails.Text != "descriptions")
                && (tbAmount.Text != "") && (tbDetails.Text != ""))
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to Delete this Information?", "Question",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("DELETE FROM cash_income WHERE Date = @Date AND " +
                                "Amount = @Amount AND Details = @Details", con);

                            cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@Amount", int.Parse(tbAmount.Text));
                            cmd.Parameters.AddWithValue("@Details", tbDetails.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearTextboxes();
                            FillDataGridIncome();
                        }
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
            else if (rbExpence.Checked == true)
            {
                if ((tbAmount.Text != "000") && (tbDetails.Text != "descriptions")
               && (tbAmount.Text != "") && (tbDetails.Text != ""))
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to Delete this Information?", "Question",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("DELETE FROM cash_expense WHERE Date = @Date AND " +
                                "Amount = @Amount AND Details = @Details", con);

                            cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@Amount", int.Parse(tbAmount.Text));
                            cmd.Parameters.AddWithValue("@Details", tbDetails.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearTextboxes();
                            FillDataGridExpense();
                        }
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
            else
            {
                MessageBox.Show("Please fill all the Type needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (rbIncome.Checked == true)
            {
                if (dateFrom.Value.Date <= dateTo.Value.Date)
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM cash_income WHERE Date BETWEEN @date1 AND @date2", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cmd.Parameters.AddWithValue("@date1", dateFrom.Value.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("@date2", dateTo.Value.ToString("MM/dd/yyyy"));
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgCashMonitor.DataSource = dt;

                    dgCashMonitor.AutoGenerateColumns = false;
                    dgCashMonitor.AllowUserToAddRows = false;
                    dgCashMonitor.AllowDrop = false;
                    dgCashMonitor.ReadOnly = true;

                    dgCashMonitor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgCashMonitor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgCashMonitor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    dateSet.Enabled = true;
                    tbAmount.Enabled = true;
                    tbDetails.Enabled = true;
                    rbIncome.Enabled = true;
                    rbExpence.Enabled = true;

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Date FROM must be less than Date TO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (rbExpence.Checked == true)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM cash_expense WHERE Date BETWEEN @date1 AND @date2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.Parameters.AddWithValue("@date1", dateFrom.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@date2", dateTo.Value.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgCashMonitor.DataSource = dt;

                dgCashMonitor.AutoGenerateColumns = false;
                dgCashMonitor.AllowUserToAddRows = false;
                dgCashMonitor.AllowDrop = false;
                dgCashMonitor.ReadOnly = true;

                dgCashMonitor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgCashMonitor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgCashMonitor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dateSet.Enabled = true;
                tbAmount.Enabled = true;
                tbDetails.Enabled = true;
                rbIncome.Enabled = true;
                rbExpence.Enabled = true;

                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the Type needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (rbIncome.Checked == true)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Income Table";

                for (int i = 1; i < dgCashMonitor.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = dgCashMonitor.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgCashMonitor.Rows.Count; i++)
                {
                    for (int j = 0; j < dgCashMonitor.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgCashMonitor.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialogue = new SaveFileDialog();
                saveFileDialogue.FileName = "Cash Monitor(INCOME)";
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
            else if (rbExpence.Checked == true)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Expence Table";

                for (int i = 1; i < dgCashMonitor.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = dgCashMonitor.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgCashMonitor.Rows.Count; i++)
                {
                    for (int j = 0; j < dgCashMonitor.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgCashMonitor.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialogue = new SaveFileDialog();
                saveFileDialogue.FileName = "Cash Monitor(EXPENCE)";
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
            else
            {
                MessageBox.Show("Check 'INCOME' or 'EXPENCE' button","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cash Monitor";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgCashMonitor);
        }
    }
}
