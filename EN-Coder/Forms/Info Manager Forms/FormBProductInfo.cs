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
using System.IO;

namespace EN_Coder.Forms.Info_Manager_Forms
{
    public partial class FormBProductInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");
        string imgLoc = "";

        public FormBProductInfo()
        {
            InitializeComponent();
        }

        #region Methods
        private void FillDataGrid()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgProductInfo.DataSource = dt;

            dgProductInfo.AutoGenerateColumns = false;
            dgProductInfo.AllowUserToAddRows = false;
            dgProductInfo.AllowDrop = false;
            dgProductInfo.ReadOnly = true;

            dgProductInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgProductInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgProductInfo.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Close();
        }

        private void ClearTextboxes()
        {
            tbPID.Text = "Product ID";
            tbPID.ForeColor = Color.Gray;

            tbPName.Text = "Product Name";
            tbPName.ForeColor = Color.Gray;

            tbPStandardPrice.Text = "Standard Price";
            tbPStandardPrice.ForeColor = Color.Gray;

            tbPOwners.Text = "Owner Earn";
            tbPOwners.ForeColor = Color.Gray;

            tbPReseller.Text = "Reseller Earn";
            tbPReseller.ForeColor = Color.Gray;

            tbPAdd.Text = "Add";
            tbPAdd.ForeColor = Color.Gray;

            tbPLess.Text = "Less";
            tbPLess.ForeColor = Color.Gray;

            tbPDescription.Text = "Description";
            tbPDescription.ForeColor = Color.Gray;

            btnPAdd.Enabled = true;
            btnPUpdate.Enabled = false;
            btnPDelete.Enabled = false;
            tbPID.Enabled = true;

            picProd.Image = null;
            btnPicSave.Enabled = false;
        }
        #endregion Methods

        #region Textbox Mouse Click Event

        private void tbPID_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPID.Text == "Product ID")
            {
                tbPID.Clear();
                tbPID.Focus();
                tbPID.ForeColor = Color.Black;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

        }

        private void tbPName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPName.Text == "Product Name")
            {
                tbPName.Clear();
                tbPName.Focus();
                tbPName.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPStandardPrice_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPStandardPrice.Text == "Standard Price")
            {
                tbPStandardPrice.Clear();
                tbPStandardPrice.Focus();
                tbPStandardPrice.ForeColor = Color.Black;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPOwners_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPOwners.Text == "Owner Earn")
            {
                tbPOwners.Clear();
                tbPOwners.Focus();
                tbPOwners.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPReseller_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPReseller.Text == "Reseller Earn")
            {
                tbPReseller.Clear();
                tbPReseller.Focus();
                tbPReseller.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPAdd.Text == "Add")
            {
                tbPAdd.Clear();
                tbPAdd.Focus();
                tbPAdd.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPLess_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPLess.Text == "Less")
            {
                tbPLess.Clear();
                tbPLess.Focus();
                tbPLess.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPDescription.TextLength == 0)
            {
                tbPDescription.Text = "Description";
                tbPDescription.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }

        private void tbPDescription_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPDescription.Text == "Description")
            {
                tbPDescription.Clear();
                tbPDescription.Focus();
                tbPDescription.ForeColor = Color.Black;
            }

            if (tbPStandardPrice.TextLength == 0)
            {
                tbPStandardPrice.Text = "Standard Price";
                tbPStandardPrice.ForeColor = Color.Gray;
            }

            if (tbPOwners.TextLength == 0)
            {
                tbPOwners.Text = "Owner Earn";
                tbPOwners.ForeColor = Color.Gray;
            }

            if (tbPReseller.TextLength == 0)
            {
                tbPReseller.Text = "Reseller Earn";
                tbPReseller.ForeColor = Color.Gray;
            }

            if (tbPAdd.TextLength == 0)
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.TextLength == 0)
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            if (tbPName.TextLength == 0)
            {
                tbPName.Text = "Product Name";
                tbPName.ForeColor = Color.Gray;
            }

            if (tbPID.TextLength == 0)
            {
                tbPID.Text = "Product ID";
                tbPID.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void FormBProductInfo_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        #region Image Methods
        private void ImgSave()
        {
            if (picProd.Image != null)
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO picture_table(pic_ID, Product_Name, Product_Image)" +
                        " VALUES (@pic_ID, @Product_Name, @Product_Image)", con);

                    cmd.Parameters.AddWithValue("@pic_ID", int.Parse(tbPID.Text));
                    cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                    cmd.Parameters.AddWithValue("@Product_Image", img);
                    cmd.ExecuteNonQuery();

                    picProd.Image = null;
                    con.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ImgUpdate()
        {
            if (picProd.Image != null)
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE picture_table SET Product_Image = @Product_Image WHERE pic_ID = @pic_ID", con);

                    cmd.Parameters.AddWithValue("@pic_ID", int.Parse(tbPID.Text));
                    cmd.Parameters.AddWithValue("@Product_Image", img);
                    cmd.ExecuteNonQuery();

                    picProd.Image = null;
                    con.Close();
                }
                catch (Exception a)
                {
                    con.Close();
                    MessageBox.Show(a.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region btnAdd
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            if ((tbPID.Text != "Product ID") && (tbPName.Text != "Product Name") && 
                (tbPStandardPrice.Text != "Standard Price") && (tbPOwners.Text != "Owner Earn") && 
                (tbPReseller.Text != "Reseller Earn") && (tbPDescription.Text != "Description") && (picProd.Image != null))
            {
                try
                {
                    if ((tbPAdd.Text != "Add") && (tbPLess.Text != "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO products_info(Product_ID, Product_Name, Standard_Price, Owner_Earn, " +
                           "Reseller_Earn, _Add, _Less, Description) VALUES (@Product_ID, @Product_Name, @Standard_Price, @Owner_Earn, " +
                           "@Reseller_Earn, @_Add, @_Less, @Description)", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Add", int.Parse(tbPAdd.Text));
                        cmd.Parameters.AddWithValue("@_Less", int.Parse(tbPLess.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("INSERT INTO products_total(Product_ID, Product_Name, Total) VALUES " +
                            "(@Product_ID, @Product_Name, @Total)", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.Parameters.AddWithValue("@Total", 0);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgSave();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text == "Add") && (tbPLess.Text == "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO products_info(Product_ID, Product_Name, Standard_Price, Owner_Earn, " +
                           "Reseller_Earn, Description) VALUES (@Product_ID, @Product_Name, @Standard_Price, @Owner_Earn, " +
                           "@Reseller_Earn, @Description)", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("INSERT INTO products_total(Product_ID, Product_Name, Total) VALUES " +
                            "(@Product_ID, @Product_Name, @Total)", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.Parameters.AddWithValue("@Total", 0);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgSave();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text == "Add") && (tbPLess.Text != "Less"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO products_info(Product_ID, Product_Name, Standard_Price, Owner_Earn, " +
                               "Reseller_Earn, _Less, Description) VALUES (@Product_ID, @Product_Name, @Standard_Price, @Owner_Earn, " +
                               "@Reseller_Earn, @_Less, @Description)", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Less", int.Parse(tbPLess.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("INSERT INTO products_total(Product_ID, Product_Name, Total) VALUES " +
                            "(@Product_ID, @Product_Name, @Total)", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.Parameters.AddWithValue("@Total", 0);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgSave();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text != "Add") && (tbPLess.Text == "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO products_info(Product_ID, Product_Name, Standard_Price, Owner_Earn, " +
                           "Reseller_Earn, _Add, Description) VALUES (@Product_ID, @Product_Name, @Standard_Price, @Owner_Earn, " +
                           "@Reseller_Earn, @_Add, @Description)", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Add", int.Parse(tbPAdd.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("INSERT INTO products_total(Product_ID, Product_Name, Total) VALUES " +
                            "(@Product_ID, @Product_Name, @Total)", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.Parameters.AddWithValue("@Total", 0);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgSave();
                        ClearTextboxes();
                        FillDataGrid();
                    }

                    MessageBox.Show("Successfuly Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Input Different Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPID.Text = "Product ID";
                    tbPID.ForeColor = Color.Gray;
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region KeyPress Event
        private void tbPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPStandardPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPOwners_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPReseller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPLess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnPClear_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }

        #region MouseDoubleClick
        private void dgProductInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbPID.Text = dgProductInfo.CurrentRow.Cells[0].Value.ToString();
            tbPName.Text = dgProductInfo.CurrentRow.Cells[1].Value.ToString();
            tbPStandardPrice.Text = dgProductInfo.CurrentRow.Cells[2].Value.ToString();
            tbPOwners.Text = dgProductInfo.CurrentRow.Cells[3].Value.ToString();
            tbPReseller.Text = dgProductInfo.CurrentRow.Cells[4].Value.ToString();
            tbPAdd.Text = dgProductInfo.CurrentRow.Cells[5].Value.ToString();
            tbPLess.Text = dgProductInfo.CurrentRow.Cells[6].Value.ToString();
            tbPDescription.Text = dgProductInfo.CurrentRow.Cells[7].Value.ToString();

            tbPID.ForeColor = Color.Black;
            tbPName.ForeColor = Color.Black;
            tbPStandardPrice.ForeColor = Color.Black;
            tbPOwners.ForeColor = Color.Black;
            tbPReseller.ForeColor = Color.Black;
            tbPAdd.ForeColor = Color.Black;
            tbPLess.ForeColor = Color.Black;
            tbPDescription.ForeColor = Color.Black;

            if (tbPAdd.Text == "")
            {
                tbPAdd.Text = "Add";
                tbPAdd.ForeColor = Color.Gray;
            }

            if (tbPLess.Text == "")
            {
                tbPLess.Text = "Less";
                tbPLess.ForeColor = Color.Gray;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM picture_table WHERE pic_ID = @pic_ID", con);

            cmd.Parameters.AddWithValue("@pic_ID", int.Parse(tbPID.Text));

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    byte[] img = (byte[])(myReader[2]);
                    if (img == null)
                    {
                        picProd.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picProd.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();

            btnPicSave.Enabled = true;
            btnPAdd.Enabled = false;
            btnPUpdate.Enabled = true;
            btnPDelete.Enabled = true;
            tbPID.Enabled = false;
        }
        #endregion

        #region btnUpdate
        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            if ((tbPID.Text != "Product ID") && (tbPName.Text != "Product Name") && (tbPStandardPrice.Text != "Standard Price") &&
           (tbPOwners.Text != "Owner Earn") && (tbPReseller.Text != "Reseller Earn") &&
           (tbPDescription.Text != "Description") && (picProd.Image != null))
            {
                try
                {
                    if ((tbPAdd.Text != "Add") && (tbPLess.Text != "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE products_info SET Product_Name = @Product_Name, " +
                            "Standard_Price = @Standard_Price, Owner_Earn = @Owner_Earn, Reseller_Earn = @Reseller_Earn, " +
                            "_Add = @_Add, _Less = @_Less, Description = @Description WHERE Product_ID = @Product_ID", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Add", int.Parse(tbPAdd.Text));
                        cmd.Parameters.AddWithValue("@_Less", int.Parse(tbPLess.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("UPDATE products_total SET Product_Name = @Product_Name " +
                            "WHERE Product_ID = @Product_ID", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgUpdate();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text == "Add") && (tbPLess.Text == "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE products_info SET Product_Name = @Product_Name, " +
                            "Standard_Price = @Standard_Price, Owner_Earn = @Owner_Earn, Reseller_Earn = @Reseller_Earn, " +
                            "_Add = NULL, _Less = NULL, Description = @Description WHERE Product_ID = @Product_ID", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("UPDATE products_total SET Product_Name = @Product_Name " +
                            "WHERE Product_ID = @Product_ID", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgUpdate();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text == "Add") && (tbPLess.Text != "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE products_info SET Product_Name = @Product_Name, " +
                            "Standard_Price = @Standard_Price, Owner_Earn = @Owner_Earn, Reseller_Earn = @Reseller_Earn, " +
                            "_Add = NULL, _Less = @_Less, Description = @Description WHERE Product_ID = @Product_ID", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Less", int.Parse(tbPLess.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("UPDATE products_total SET Product_Name = @Product_Name " +
                            "WHERE Product_ID = @Product_ID", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgUpdate();
                        ClearTextboxes();
                        FillDataGrid();
                    }
                    else if ((tbPAdd.Text != "Add") && (tbPLess.Text == "Less"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE products_info SET Product_Name = @Product_Name, " +
                            "Standard_Price = @Standard_Price, Owner_Earn = @Owner_Earn, Reseller_Earn = @Reseller_Earn, " +
                            "_Add = @_Add, _Less = NULL, Description = @Description WHERE Product_ID = @Product_ID", con);

                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd.Parameters.AddWithValue("@Standard_Price", int.Parse(tbPStandardPrice.Text));
                        cmd.Parameters.AddWithValue("@Owner_Earn", int.Parse(tbPOwners.Text));
                        cmd.Parameters.AddWithValue("@Reseller_Earn", int.Parse(tbPReseller.Text));
                        cmd.Parameters.AddWithValue("@_Add", int.Parse(tbPAdd.Text));
                        cmd.Parameters.AddWithValue("@Description", tbPDescription.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("UPDATE products_total SET Product_Name = @Product_Name " +
                            "WHERE Product_ID = @Product_ID", con);

                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.Parameters.AddWithValue("@Product_Name", tbPName.Text);
                        cmd1.ExecuteNonQuery();

                        con.Close();
                        ImgUpdate();
                        ClearTextboxes();
                        FillDataGrid();
                    }

                    MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion btnUpdate

        #region btnDelete
        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (tbPID.Text != "Product ID")
            {
                try
                {
                    if (MessageBox.Show("Do you want to Delete " + tbPName.Text + "'s Information?", "Question",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM products_info WHERE Product_ID = @Product_ID", con);
                        cmd.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("DELETE FROM products_total WHERE Product_ID = @Product_ID", con);
                        cmd1.Parameters.AddWithValue("@Product_ID", int.Parse(tbPID.Text));
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("DELETE FROM picture_table WHERE pic_ID = @pic_ID", con);
                        cmd2.Parameters.AddWithValue("@pic_ID", int.Parse(tbPID.Text));
                        cmd2.ExecuteNonQuery();

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
                MessageBox.Show("Please fill the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Other Buttons
        private void btnExtract_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Products Table";

            for (int i = 1; i < dgProductInfo.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dgProductInfo.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgProductInfo.Rows.Count; i++)
            {
                for (int j = 0; j < dgProductInfo.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgProductInfo.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.FileName = "Products Informations";
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
            printer.Title = "Products Information";
            printer.SubTitle = string.Format("Date Exported: " + DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Product Management System";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgProductInfo);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Product Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picProd.ImageLocation = imgLoc;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG Files (*.jpg)|*.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picProd.Image.Save(sfd.FileName);
            }
        }
        #endregion
    }
}
