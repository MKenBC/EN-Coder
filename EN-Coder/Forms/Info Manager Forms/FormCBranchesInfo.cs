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
    public partial class FormCBranchesInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormCBranchesInfo()
        {
            InitializeComponent();
            FillDataGrid();
            FillComboReseller();
        }

        private void FillComboReseller()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM resellers_info", con);

            SqlDataReader myReader;
            cbUsername.Items.Clear();

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string n = myReader.GetString(1);
                    cbUsername.Items.Add(n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }

        private void ClearText()
        {
            tbID.Text = "Account ID";
            tbPassword.Text = "Password";
            cbUsername.SelectedItem = null;

            tbID.ForeColor = tbPassword.ForeColor = Color.Gray;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cbUsername.Enabled = true;
            tbID.Enabled = true;
        }

        private void FillDataGrid()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM account_table", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgAccounts.DataSource = dt;

            dgAccounts.AutoGenerateColumns = false;
            dgAccounts.AllowUserToAddRows = false;
            dgAccounts.AllowDrop = false;
            dgAccounts.ReadOnly = true;

            dgAccounts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgAccounts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgAccounts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void cbUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPassword.TextLength == 0)
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Gray;
            }

            if (tbID.TextLength == 0)
            {
                tbID.Text = "Account ID";
                tbID.ForeColor = Color.Gray;
            }
        }

        private void tbID_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbID.Text == "Account ID")
            {
                tbID.Clear();
                tbID.Focus();
                tbID.ForeColor = Color.Black;
            }


            if (tbPassword.TextLength == 0)
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Gray;
            }
        }


        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Clear();
                tbPassword.Focus();
                tbPassword.ForeColor = Color.Black;
            }

            if (tbID.TextLength == 0)
            {
                tbID.Text = "Account ID";
                tbID.ForeColor = Color.Gray;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillDataGrid();
            ClearText();
        }

        private void dgAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbID.Text = dgAccounts.CurrentRow.Cells[0].Value.ToString();
            cbUsername.Text = dgAccounts.CurrentRow.Cells[1].Value.ToString();
            tbPassword.Text = dgAccounts.CurrentRow.Cells[2].Value.ToString();

            tbID.ForeColor = Color.Black;
            tbPassword.ForeColor = Color.Black;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            cbUsername.Enabled = false;
            tbID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbID.Text != "Account ID") && (cbUsername.SelectedItem != null) && (tbPassword.Text != "Password"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO account_table(Account_ID, Username, Password)" +
                        " VALUES (@Account_ID, @Username, @Password)", con);

                    cmd.Parameters.AddWithValue("@Account_ID", int.Parse(tbID.Text)); ;
                    cmd.Parameters.AddWithValue("@Username", cbUsername.SelectedItem);
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText();
                    FillDataGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Input Different Resellers ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbID.Text = "Account ID";
                    tbID.ForeColor = Color.Gray;
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((tbID.Text != "Account ID") && (cbUsername.SelectedItem != null) && (tbPassword.Text != "Password"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE account_table SET Username = @Username, Password = @Password WHERE Account_ID = @Account_ID", con);

                    cmd.Parameters.AddWithValue("@Account_ID", int.Parse(tbID.Text)); ;
                    cmd.Parameters.AddWithValue("@Username", cbUsername.SelectedItem);
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText();
                    FillDataGrid();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "Account ID")
            {
                try
                {
                    if (MessageBox.Show("Do you want to Delete " + cbUsername.SelectedItem.ToString() + "'s Account?", "Question",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM account_table WHERE Account_ID = @Account_ID", con);
                        cmd.Parameters.AddWithValue("@Account_ID", int.Parse(tbID.Text)); ;
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearText();
                        FillDataGrid();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Accounts Sheet";

            for (int i = 1; i < dgAccounts.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dgAccounts.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgAccounts.Rows.Count; i++)
            {
                for (int j = 0; j < dgAccounts.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgAccounts.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Account Informations";
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
            printer.Title = "Accounts Information";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgAccounts);
        }
    }
}
