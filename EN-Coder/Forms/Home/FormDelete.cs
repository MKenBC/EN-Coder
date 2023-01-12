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
using System.Runtime.InteropServices;

namespace EN_Coder.Forms.Home
{
    public partial class FormDelete : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormDelete()
        {
            InitializeComponent();

            Random rnd = new Random();

            txtPin.Text = rnd.Next(1000,10000).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmUpdate_Click(object sender, EventArgs e)
        {

            if ((tbPassword1.Text != "Password") && (tbPassword1.TextLength != 0)
                && (tbPassword2.Text != "Password") && (tbPassword2.TextLength != 0)
                && (tbPin.Text != "Pin Code") && (tbPin.TextLength != 0))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM owner_table WHERE user_ID = 1", con);

                SqlDataReader myReader;

                try
                {
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        string n1 = myReader.GetString(2);

                        if ((tbPin.Text == txtPin.Text) && (n1 == tbPassword1.Text) && (n1 == tbPassword2.Text))
                        {
                            if (MessageBox.Show("Do you want to Delete Your Account?\n - This will delete all your DATA and TABLES", "Question", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlCommand cmd1 = new SqlCommand("DELETE * FROM account_table", con);
                                SqlCommand cmd2 = new SqlCommand("DELETE * FROM cash_expense", con);
                                SqlCommand cmd3 = new SqlCommand("DELETE * FROM cash_income", con);
                                SqlCommand cmd4 = new SqlCommand("DELETE * FROM encode_table", con);
                                SqlCommand cmd5 = new SqlCommand("DELETE * FROM owner_table", con);
                                SqlCommand cmd6 = new SqlCommand("DELETE * FROM picture_table", con);
                                SqlCommand cmd7 = new SqlCommand("DELETE * FROM products_history", con);
                                SqlCommand cmd8 = new SqlCommand("DELETE * FROM products_info", con);
                                SqlCommand cmd9 = new SqlCommand("DELETE * FROM products_total", con);
                                SqlCommand cmd0 = new SqlCommand("DELETE * FROM resellers_info", con);

                                MessageBox.Show("Account Successfully Deleted", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Exit();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Pin Code or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Mouse Click
        private void tbPassword1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPassword1.Text == "Password")
            {
                tbPassword1.Clear();
                tbPassword1.Focus();
                tbPassword1.ForeColor = Color.Black;
                tbPassword1.PasswordChar = '*';
            }

            if (tbPassword2.TextLength == 0)
            {
                tbPassword2.Text = "Password";
                tbPassword2.ForeColor = Color.Gray;
                tbPassword2.PasswordChar = '\0';
            }

            if (tbPin.TextLength == 0)
            {
                tbPin.Text = "Pin Code";
                tbPin.ForeColor = Color.Gray;
            }
        }

        private void tbPassword2_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPassword2.Text == "Password")
            {
                tbPassword2.Clear();
                tbPassword2.Focus();
                tbPassword2.ForeColor = Color.Black;
                tbPassword2.PasswordChar = '*';
            }

            if (tbPassword1.TextLength == 0)
            {
                tbPassword1.Text = "Password";
                tbPassword1.ForeColor = Color.Gray;
                tbPassword1.PasswordChar = '\0';
            }

            if (tbPin.TextLength == 0)
            {
                tbPin.Text = "Pin Code";
                tbPin.ForeColor = Color.Gray;
            }
        }

        private void tbPin_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPin.Text == "Pin Code")
            {
                tbPin.Clear();
                tbPin.Focus();
                tbPin.ForeColor = Color.Black;
            }

            if (tbPassword1.TextLength == 0)
            {
                tbPassword1.Text = "Password";
                tbPassword1.ForeColor = Color.Gray;
                tbPassword1.PasswordChar = '\0';
            }

            if (tbPassword2.TextLength == 0)
            {
                tbPassword2.Text = "Password";
                tbPassword2.ForeColor = Color.Gray;
                tbPassword2.PasswordChar = '\0';
            }
        }
        #endregion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pCreateAcc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormDelete_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
