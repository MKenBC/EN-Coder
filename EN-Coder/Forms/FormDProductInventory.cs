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
    public partial class FormDProductInventory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormDProductInventory()
        {
            InitializeComponent();
        }

        #region Methods
        private void ResetID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_history", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if ((dt.Rows.Count > 0) && (dt.Rows[0][0] != DBNull.Value))
            {
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("DBCC CHECKIDENT ('products_history', RESEED, 0)", con);
                cmd1.ExecuteNonQuery();
            }

            con.Close();
        }

        private void FillDataGrid()
        {
            ResetID();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_history", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgProductInventory.DataSource = dt;
            
            dgProductInventory.AutoGenerateColumns = false;
            dgProductInventory.AllowUserToAddRows = false;
            dgProductInventory.AllowDrop = false;
            dgProductInventory.ReadOnly = true;

            dgProductInventory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInventory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void FillCombo()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_info", con);
            
            SqlDataReader myReader;
            cbPName.Items.Clear();

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string n = myReader.GetString(1);
                    cbPName.Items.Add(n);
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
            cbPName.Enabled = true;
            cbPName.Text = "Product Name";
            cbPName.ForeColor = Color.Gray;

            tbStocks.Enabled = true;
            tbStocks.Text = "Quantity";
            tbStocks.ForeColor = Color.Gray;

            tbDescription.Enabled = true;
            tbDescription.Text = "Description";
            tbDescription.ForeColor = Color.Gray;

            rbAdd.Enabled = true;
            rbAdd.Checked = false;

            rbLess.Enabled = true;
            rbLess.Checked = false;

            dateSet.Enabled = true;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            lbStocks.Text = "0";
            btnAdd.Text = "?";
        }

        private void RefreshTotal()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
            cmd.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
            cmd.ExecuteNonQuery();
            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string n = myReader.GetValue(2).ToString();
                    lbStocks.Text = n;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }
        #endregion

        #region MouseClick Event
        private void tbStocks_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbStocks.Text == "Quantity")
            {
                tbStocks.Text = "";
                tbStocks.Focus();
                tbStocks.ForeColor = Color.Black;
            }

            if (tbDescription.TextLength == 0)
            {
                tbDescription.Text = "Description";
                tbDescription.ForeColor = Color.Gray;
            }
        }

        private void tbDescription_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbDescription.Text == "Description")
            {
                tbDescription.Text = "";
                tbDescription.Focus();
                tbDescription.ForeColor = Color.Black;
            }

            if (tbStocks.TextLength == 0)
            {
                tbStocks.Text = "Quantity";
                tbStocks.ForeColor = Color.Gray;
            }
        }
        #endregion


        private void FormDProductInventory_Load(object sender, EventArgs e)
        {
            FillCombo();
            FillDataGrid();
        }

        private void cbPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTotal();  
        }

        #region btnADD or LESS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((cbPName.SelectedItem != null) && (tbStocks.Text != "Quantity") && (tbDescription.Text != "Description"))
            {
                if (btnAdd.Text == "Add")
                {
                    try
                    {
                        int n = 0, m = 0;

                        //Get total value from products_total
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
                        cmd1.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                        cmd1.ExecuteNonQuery();
                        SqlDataReader myReader = cmd1.ExecuteReader();
                        while (myReader.Read())
                        {
                            n = myReader.GetInt32(2);
                        }
                        con.Close();

                        //insert datas to products_history
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO products_history(Product_name, Quantity, Balance" +
                            ", Type, Date, Description)" +
                            " VALUES (@Product_name, @Quantity, @Balance, @Type, @Date, @Description)", con);
                        cmd.Parameters.AddWithValue("@Product_name", cbPName.SelectedItem);
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbStocks.Text));
                        m = n + (Convert.ToInt32(tbStocks.Text));
                        cmd.Parameters.AddWithValue("@Balance", m);
                        cmd.Parameters.AddWithValue("@Type", "ADD");
                        cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //update the total value to products_total
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                        cmd2.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                        cmd2.Parameters.AddWithValue("@Total", m);
                        cmd2.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Stock Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearText();
                        FillDataGrid();
                        RefreshTotal();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (btnAdd.Text == "Less")
                {
                    try
                    {
                        int n = 0, m = 0;

                        //Get total value from products_total
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
                        cmd1.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                        cmd1.ExecuteNonQuery();
                        SqlDataReader myReader = cmd1.ExecuteReader();
                        while (myReader.Read())
                        {
                            n = myReader.GetInt32(2);
                        }
                        con.Close();

                        if (n >= (Convert.ToInt32(tbStocks.Text)))
                        {
                            //insert datas to products_history
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO products_history(Product_name, Quantity, Balance" +
                                ", Type, Date, Description)" +
                                " VALUES (@Product_name, @Quantity, @Balance, @Type, @Date, @Description)", con);
                            cmd.Parameters.AddWithValue("@Product_name", cbPName.SelectedItem);
                            cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbStocks.Text));
                            m = n - (Convert.ToInt32(tbStocks.Text));
                            cmd.Parameters.AddWithValue("@Balance", m);
                            cmd.Parameters.AddWithValue("@Type", "LESS");
                            cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //update the total value to products_total
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                            cmd2.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                            cmd2.Parameters.AddWithValue("@Total", m);
                            cmd2.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Stocks Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshTotal();
                            ClearText();
                            FillDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("The \"Less Value\" is Greater Than \"Total Value\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
        }

        private void rbLess_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Less";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillDataGrid();
            ClearText();
        }

        private void tbStocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((cbPName.SelectedItem != null) && (tbStocks.Text != "Quantity") && (tbDescription.Text != "Description"))
            {
                int n = 0;

                //Get total value from products_total
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
                cmd1.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                cmd1.ExecuteNonQuery();
                SqlDataReader myReader = cmd1.ExecuteReader();
                while (myReader.Read())
                {
                    n = myReader.GetInt32(2);
                }
                con.Close();

                if (rbAdd.Checked == true)
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to Delete this Information?", "Question",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int m = 0;
                            con.Open();

                            SqlCommand cmd = new SqlCommand("DELETE FROM products_history WHERE Transaction_ID = @ID", con);

                            cmd.Parameters.AddWithValue("@ID", int.Parse(dgProductInventory.CurrentRow.Cells[0].Value.ToString()));
                            cmd.ExecuteNonQuery();
                            con.Close();

                            m = n - int.Parse(tbStocks.Text);

                            //update the total value to products_total
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                            cmd2.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                            cmd2.Parameters.AddWithValue("@Total", m);
                            cmd2.ExecuteNonQuery();
                            con.Close();

                            FillDataGrid();
                            ClearText();
                            MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbLess.Checked == true)
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to Delete this Information?", "Question",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int m = 0;
                            con.Open();

                            SqlCommand cmd = new SqlCommand("DELETE FROM products_history WHERE Transaction_ID = @ID", con);

                            cmd.Parameters.AddWithValue("@ID", int.Parse(dgProductInventory.CurrentRow.Cells[0].Value.ToString()));
                            cmd.ExecuteNonQuery();
                            con.Close();

                            m = n + int.Parse(tbStocks.Text);

                            //update the total value to products_total
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                            cmd2.Parameters.AddWithValue("@Product_Name", cbPName.SelectedItem);
                            cmd2.Parameters.AddWithValue("@Total", m);
                            cmd2.ExecuteNonQuery();
                            con.Close();

                            FillDataGrid();
                            ClearText();
                            MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date <= dateTo.Value.Date)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM products_history WHERE Date BETWEEN @date1 AND @date2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.Parameters.AddWithValue("@date1", dateFrom.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@date2", dateTo.Value.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgProductInventory.DataSource = dt;

                dgProductInventory.AutoGenerateColumns = false;
                dgProductInventory.AllowUserToAddRows = false;
                dgProductInventory.AllowDrop = false;
                dgProductInventory.ReadOnly = true;

                dgProductInventory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgProductInventory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                con.Close();
            }
            else
            {
                MessageBox.Show("Date FROM must be less than Date TO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgProductInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbPName.SelectedItem = dgProductInventory.CurrentRow.Cells[1].Value.ToString();
            cbPName.Text = dgProductInventory.CurrentRow.Cells[1].Value.ToString();
            cbPName.ForeColor = Color.Black;
            dateSet.Value = DateTime.ParseExact(dgProductInventory.CurrentRow.Cells[5].Value.ToString(),
                "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            tbStocks.Text = dgProductInventory.CurrentRow.Cells[2].Value.ToString();
            tbStocks.ForeColor = Color.Black;
            tbDescription.Text = dgProductInventory.CurrentRow.Cells[6].Value.ToString();
            tbDescription.ForeColor = Color.Black;
            if (dgProductInventory.CurrentRow.Cells[4].Value.ToString() == "ADD")
            {
                rbAdd.Checked = true;
            }

            if (dgProductInventory.CurrentRow.Cells[4].Value.ToString() == "LESS")
            {
                rbLess.Checked = true;
            }

            RefreshTotal();

            cbPName.Enabled = false;
            tbStocks.Enabled = false;
            tbDescription.Enabled = false;
            rbAdd.Enabled = false;
            rbLess.Enabled = false;
            dateSet.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Product Inventory Table";

            for (int i = 1; i < dgProductInventory.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dgProductInventory.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgProductInventory.Rows.Count; i++)
            {
                for (int j = 0; j < dgProductInventory.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgProductInventory.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Product Inventory";
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
            printer.Title = "Product Inventory";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgProductInventory);
        }
    }
}
