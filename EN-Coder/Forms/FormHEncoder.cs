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
    public partial class FormHEncoder : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormHEncoder()
        {
            InitializeComponent();
            FillComboProduct();
            FillComboReseller();
            FillDataGrid();
        }

        #region Methods
        private void TextChange()
        {
            if (cbProductName.SelectedItem != null)
            {
                if ((tbPriceGiven.Text != "") && (tbPriceGiven.Text != "000"))
                {
                    int stand = 0, pGiven = int.Parse(tbPriceGiven.Text), pHold = 0, earn = 0;

                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM products_info WHERE Product_Name = @Product_Name", con);
                    cmd.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                    cmd.ExecuteNonQuery();
                    SqlDataReader myReader;

                    ActivateText();

                    try
                    {
                        myReader = cmd.ExecuteReader();

                        while (myReader.Read())
                        {
                            stand = myReader.GetInt32(2);
                            earn = myReader.GetInt32(4);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                    con.Close();

                    if (stand > pGiven)
                    {
                        pHold = stand - pGiven;

                        if ((tbQuantity.Text != "000") && (tbQuantity.Text != ""))
                        {
                            int nSmall = pHold * (int.Parse(tbQuantity.Text));
                            int nEarn = earn * (int.Parse(tbQuantity.Text));
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd) - (nSmall + nLess)).ToString();
                        }
                        else
                        {
                            int nSmall = pHold;
                            int nEarn = earn;
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd) - (nSmall + nLess)).ToString();
                        }
                    }
                    else if (stand < pGiven)
                    {
                        pHold = pGiven - stand;

                        if ((tbQuantity.Text != "000") && (tbQuantity.Text != ""))
                        {
                            int nLarge = pHold * (int.Parse(tbQuantity.Text));
                            int nEarn = earn * (int.Parse(tbQuantity.Text));
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd + nLarge) - nLess).ToString();
                        }
                        else
                        {
                            int nLarge = pHold;
                            int nEarn = earn;
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd + nLarge) - nLess).ToString();
                        }
                    }
                    else if (stand == pGiven)
                    {
                        if ((tbQuantity.Text != "000") && (tbQuantity.Text != ""))
                        {
                            int nEarn = earn * (int.Parse(tbQuantity.Text));
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text)) * (int.Parse(tbQuantity.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd) - nLess).ToString();
                        }
                        else
                        {
                            int nEarn = earn;
                            int nAdd = 0, nLess = 0;
                            if ((tbLess.Text != "") && (tbLess.Text != "000"))
                            {
                                nLess = (int.Parse(tbLess.Text));
                            }
                            else
                            {
                                nLess = 0;
                            }

                            if ((tbAdd.Text != "") && (tbAdd.Text != "000"))
                            {
                                nAdd = (int.Parse(tbAdd.Text));
                            }
                            else
                            {
                                nAdd = 0;
                            }

                            tbIncome.Text = ((nEarn + nAdd) - nLess).ToString();
                        }
                    }
                }
            }
        }

        private void FillComboProduct()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_info", con);

            SqlDataReader myReader;
            cbProductName.Items.Clear();

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string n = myReader.GetString(1);
                    cbProductName.Items.Add(n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }

        private void FillComboReseller()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM resellers_info", con);

            SqlDataReader myReader;
            cbResellersName.Items.Clear();

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string n = myReader.GetString(1);
                    cbResellersName.Items.Add(n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }

        private void ResetID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM encode_table", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if ((dt.Rows.Count > 0) && (dt.Rows[0][0] != DBNull.Value))
            {
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("DBCC CHECKIDENT ('encode_table', RESEED, 0)", con);
                cmd1.ExecuteNonQuery();
            }

            con.Close();
        }

        private void FillDataGrid()
        {
            ResetID();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM encode_table", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgEncoder.DataSource = dt;

            dgEncoder.AutoGenerateColumns = false;
            dgEncoder.AllowUserToAddRows = false;
            dgEncoder.AllowDrop = false;
            dgEncoder.ReadOnly = true;

            dgEncoder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEncoder.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void ClearText()
        {

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;

            cbProductName.Enabled = true;
            cbResellersName.Enabled = true;
            tbPriceGiven.Enabled = false;
            tbQuantity.Enabled = false;
            tbAdd.Enabled = false;
            tbLess.Enabled = false;
            tbDetails.Enabled = false;
            dateSet.Enabled = false;

            cbProductName.SelectedItem = null;
            cbResellersName.SelectedItem = null;

            tbPriceGiven.Text = tbQuantity.Text = tbAdd.Text = tbLess.Text = tbIncome.Text = "000";
            tbPriceGiven.ForeColor = tbQuantity.ForeColor = tbAdd.ForeColor = tbLess.ForeColor = tbIncome.ForeColor = Color.Gray;

            tbDetails.Text = "descriptions";
            tbDetails.ForeColor = Color.Gray;
        }

        private void ActivateText()
        {
            tbPriceGiven.Enabled = true;
            tbQuantity.Enabled = true;
            tbAdd.Enabled = true;
            tbLess.Enabled = true;
            tbDetails.Enabled = true;
            dateSet.Enabled = true;
        }
        #endregion

        #region MouseClick
        private void cbProductName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void cbResellersName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void tbPriceGiven_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPriceGiven.Text == "000")
            {
                tbPriceGiven.Text = "";
                tbPriceGiven.Focus();
                tbPriceGiven.ForeColor = Color.Black;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void tbDetails_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbDetails.Text == "descriptions")
            {
                tbDetails.Text = "";
                tbDetails.Focus();
                tbDetails.ForeColor = Color.Black;
            }

            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void tbAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbAdd.Text == "000")
            {
                tbAdd.Text = "";
                tbAdd.Focus();
                tbAdd.ForeColor = Color.Black;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void tbLess_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbLess.Text == "000")
            {
                tbLess.Text = "";
                tbLess.Focus();
                tbLess.ForeColor = Color.Black;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }

            if (tbQuantity.TextLength == 0)
            {
                tbQuantity.Text = "000";
                tbQuantity.ForeColor = Color.Gray;
            }
        }

        private void tbQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbQuantity.Text == "000")
            {
                tbQuantity.Text = "";
                tbQuantity.Focus();
                tbQuantity.ForeColor = Color.Black;
            }

            if (tbDetails.TextLength == 0)
            {
                tbDetails.Text = "descriptions";
                tbDetails.ForeColor = Color.Gray;
            }

            if (tbPriceGiven.TextLength == 0)
            {
                tbPriceGiven.Text = "000";
                tbPriceGiven.ForeColor = Color.Gray;
            }

            if (tbAdd.TextLength == 0)
            {
                tbAdd.Text = "000";
                tbAdd.ForeColor = Color.Gray;
            }

            if (tbLess.TextLength == 0)
            {
                tbLess.Text = "000";
                tbLess.ForeColor = Color.Gray;
            }

            if (tbIncome.TextLength == 0)
            {
                tbIncome.Text = "000";
                tbIncome.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            FillDataGrid();
        }

        #region KeyPress
        private void tbPriceGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbLess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region SelectedIndexChanged
        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductName.SelectedItem != null)
            {
                int a = 0, l = 0, stand = 0;
                string pGiven = "",
                        tAdd = "",
                        tLess = "";

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM products_info WHERE Product_Name = @Product_Name", con);
                cmd.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                cmd.ExecuteNonQuery();
                SqlDataReader myReader;

                ActivateText();

                try
                {
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        stand = myReader.GetInt32(4);
                        pGiven = myReader.GetValue(2).ToString();
                        tAdd = myReader.GetValue(5).ToString();
                        tLess = myReader.GetValue(6).ToString();


                    }

                    con.Close();

                    tbPriceGiven.Text = pGiven;
                    tbPriceGiven.ForeColor = Color.Black;

                    if (tAdd != "")
                    {
                        tbAdd.Text = tAdd;
                        tbAdd.ForeColor = Color.Black;

                        a = stand + int.Parse(tAdd);
                    }
                    else
                    {
                        tbAdd.Text = "000";
                        tbAdd.ForeColor = Color.Gray;
                        a = stand;
                    }

                    if (tLess != "")
                    {
                        tbLess.Text = tLess;
                        tbLess.ForeColor = Color.Black;

                        l = a - int.Parse(tLess);
                    }
                    else
                    {
                        l = a;
                        tbLess.Text = "000";
                        tbLess.ForeColor = Color.Gray;
                    }

                    tbIncome.Text = l.ToString();
                    tbIncome.ForeColor = Color.Black;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        #endregion

        #region TextChanged
        private void tbPriceGiven_TextChanged(object sender, EventArgs e)
        {
            TextChange();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            TextChange();
        }

        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
            TextChange();
        }

        private void tbLess_TextChanged(object sender, EventArgs e)
        {
            TextChange();
        }
        #endregion

        #region Button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((cbResellersName.SelectedItem != null) && (cbProductName.SelectedItem != null) 
                && (tbDetails.Text != "descriptions") && (tbDetails.Text != "")
                && (tbQuantity.Text != "000") && (tbQuantity.Text != ""))
            {
                try
                {
                    int stocks = 0, m = 0;

                    //Get total value from products_total
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
                    cmd1.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                    cmd1.ExecuteNonQuery();
                    SqlDataReader myReader = cmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        stocks = myReader.GetInt32(2);
                    }
                    con.Close();

                    if (stocks >= (int.Parse(tbQuantity.Text)))
                    {
                        #region Products Total & History
                            //insert datas to products_history
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO products_history(Product_name, Quantity, Balance" +
                                ", Type, Date, Description)" +
                                " VALUES (@Product_name, @Quantity, @Balance, @Type, @Date, @Description)", con);
                            cmd.Parameters.AddWithValue("@Product_name", cbProductName.SelectedItem);
                            cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbQuantity.Text));
                            m = stocks - (Convert.ToInt32(tbQuantity.Text));
                            cmd.Parameters.AddWithValue("@Balance", m);
                            cmd.Parameters.AddWithValue("@Type", "LESS");
                            cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@Description", "Reseller Sales, Name: " + cbResellersName.SelectedItem + ", Product: " + cbProductName.SelectedItem + ", Details:" + tbDetails.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //update the total value to products_total
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                            cmd2.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                            cmd2.Parameters.AddWithValue("@Total", m);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            #endregion

                        #region Cash In
                            try
                            {
                                //read the owners income
                                con.Open();
                                int own = 0, income = 0;
                                SqlCommand cmd3 = new SqlCommand("SELECT * FROM products_info WHERE Product_Name = @Product_Name", con);
                                cmd3.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                                cmd3.ExecuteNonQuery();
                                SqlDataReader myReader1;
                                ActivateText();
                                try
                                {
                                    myReader1 = cmd3.ExecuteReader();
                                    while (myReader1.Read())
                                    {
                                        own = myReader1.GetInt32(3);
                                        income = own * int.Parse(tbQuantity.Text);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }
                                con.Close();

                                //set to cash in
                                con.Open();
                                SqlCommand cmd4 = new SqlCommand("INSERT INTO cash_income(Date, Amount, Details)" +
                                    " VALUES (@Date, @Amount, @Details)", con);

                                cmd4.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                                cmd4.Parameters.AddWithValue("@Amount", income);
                                cmd4.Parameters.AddWithValue("@Details", "Reseller Sales, Name: " + cbResellersName.SelectedItem + ", Product: " + cbProductName.SelectedItem + ", Details:" + tbDetails.Text);
                                cmd4.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                        #region Resellers Table
                            try
                            {
                                con.Open();
                                SqlCommand cmd5 = new SqlCommand("INSERT INTO encode_table(Resellers_Name, Product_Name, Date, Price_Given, Quantity, _Add, _Less, Income, Details)" +
                                    " VALUES (@Resellers_Name, @Product_Name, @Date, @Price_Given, @Quantity, @_Add, @_Less, @Income, @Details)", con);
                                cmd5.Parameters.AddWithValue("@Resellers_Name", cbResellersName.SelectedItem);
                                cmd5.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                                cmd5.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                                cmd5.Parameters.AddWithValue("@Price_Given", int.Parse(tbPriceGiven.Text));
                                cmd5.Parameters.AddWithValue("@Quantity", int.Parse(tbQuantity.Text));
                                cmd5.Parameters.AddWithValue("@_Add", int.Parse(tbAdd.Text));
                                cmd5.Parameters.AddWithValue("@_Less", int.Parse(tbLess.Text));
                                cmd5.Parameters.AddWithValue("@Income", int.Parse(tbIncome.Text));
                                cmd5.Parameters.AddWithValue("@Details", tbDetails.Text);
                                cmd5.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Not Enough Stocks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                        MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearText();
                        FillDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Stocks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        #region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date <= dateTo.Value.Date)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM encode_table WHERE Date BETWEEN @date1 AND @date2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.Parameters.AddWithValue("@date1", dateFrom.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@date2", dateTo.Value.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgEncoder.DataSource = dt;

                dgEncoder.AutoGenerateColumns = false;
                dgEncoder.AllowUserToAddRows = false;
                dgEncoder.AllowDrop = false;
                dgEncoder.ReadOnly = true;

                dgEncoder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgEncoder.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                con.Close();
            }
            else
            {
                MessageBox.Show("Date FROM must be less than Date TO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((cbResellersName.SelectedItem != null) && (cbProductName.SelectedItem != null)
               && (tbDetails.Text != "descriptions") && (tbDetails.Text != "")
               && (tbQuantity.Text != "000") && (tbQuantity.Text != ""))
            {
                try
                {
                    if (MessageBox.Show("Do you want to Delete this Information?", "Question",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int stocks = 0, m = 0;

                        //Get total value from products_total
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM products_total WHERE Product_Name = @Product_Name", con);
                        cmd1.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                        cmd1.ExecuteNonQuery();
                        SqlDataReader myReader = cmd1.ExecuteReader();
                        while (myReader.Read())
                        {
                            stocks = myReader.GetInt32(2);
                        }
                        con.Close();

                        if (stocks >= (int.Parse(tbQuantity.Text)))
                        {
                            #region Products Total & History
                            //dalete datas to products_history
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM products_history WHERE Product_name = @Product_name " +
                                "AND Quantity = @Quantity AND Type = @Type AND Date = @Date AND Description = @Description", con);
                            cmd.Parameters.AddWithValue("@Product_name", cbProductName.SelectedItem);
                            cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbQuantity.Text));
                            m = stocks + (Convert.ToInt32(tbQuantity.Text));
                            cmd.Parameters.AddWithValue("@Type", "LESS");
                            cmd.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@Description", "Reseller Sales, Name: " + cbResellersName.SelectedItem + ", Product: " + cbProductName.SelectedItem + ", Details:" + tbDetails.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //update the total value to products_total
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE products_total SET Total = @Total WHERE Product_Name = @Product_Name", con);
                            cmd2.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                            cmd2.Parameters.AddWithValue("@Total", m);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            #endregion

                            #region Cash In
                            try
                            {
                                //read the owners income
                                con.Open();
                                int own = 0, income = 0;
                                SqlCommand cmd3 = new SqlCommand("SELECT * FROM products_info WHERE Product_Name = @Product_Name", con);
                                cmd3.Parameters.AddWithValue("@Product_Name", cbProductName.SelectedItem);
                                cmd3.ExecuteNonQuery();
                                SqlDataReader myReader1;
                                ActivateText();
                                try
                                {
                                    myReader1 = cmd3.ExecuteReader();
                                    while (myReader1.Read())
                                    {
                                        own = myReader1.GetInt32(3);
                                        income = own * int.Parse(tbQuantity.Text);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }
                                con.Close();

                                //delete to cash in
                                con.Open();
                                SqlCommand cmd4 = new SqlCommand("DELETE FROM cash_income WHERE Date = @Date AND Amount = @Amount AND Details = @Details", con);

                                cmd4.Parameters.AddWithValue("@Date", dateSet.Value.ToString("MM/dd/yyyy"));
                                cmd4.Parameters.AddWithValue("@Amount", income);
                                cmd4.Parameters.AddWithValue("@Details", "Reseller Sales, Name: " + cbResellersName.SelectedItem + ", Product: " + cbProductName.SelectedItem + ", Details:" + tbDetails.Text);
                                cmd4.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                            #region Resellers Table
                            try
                            {
                                con.Open();
                                SqlCommand cmd5 = new SqlCommand("DELETE FROM encode_table WHERE ID = @ID", con);
                                cmd5.Parameters.AddWithValue("@ID", int.Parse(dgEncoder.CurrentRow.Cells[0].Value.ToString()));
                                cmd5.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                            MessageBox.Show("Successfuly Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearText();
                            FillDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Not Enough Stocks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        #endregion

        #region MouseDoubleClick
        private void dgEncoder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbResellersName.SelectedItem = dgEncoder.CurrentRow.Cells[1].Value.ToString();
            cbProductName.SelectedItem = dgEncoder.CurrentRow.Cells[2].Value.ToString();
            dateSet.Value = DateTime.ParseExact(dgEncoder.CurrentRow.Cells[3].Value.ToString(),
                "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            tbPriceGiven.Text = dgEncoder.CurrentRow.Cells[4].Value.ToString();
            tbQuantity.Text = dgEncoder.CurrentRow.Cells[5].Value.ToString();
            tbAdd.Text = dgEncoder.CurrentRow.Cells[6].Value.ToString();
            tbLess.Text = dgEncoder.CurrentRow.Cells[7].Value.ToString();
            tbIncome.Text = dgEncoder.CurrentRow.Cells[8].Value.ToString();
            tbDetails.Text = dgEncoder.CurrentRow.Cells[9].Value.ToString();


            cbProductName.Enabled = false;
            cbResellersName.Enabled = false;
            tbPriceGiven.Enabled = false;
            tbQuantity.Enabled = false;
            tbAdd.Enabled = false;
            tbLess.Enabled = false;
            tbDetails.Enabled = false;
            dateSet.Enabled = false;

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
        }
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Encoding Table";

            for (int i = 1; i < dgEncoder.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dgEncoder.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgEncoder.Rows.Count; i++)
            {
                for (int j = 0; j < dgEncoder.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgEncoder.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Encoder Information";
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
            printer.Title = "Encoder";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgEncoder);
        }
    }
}
