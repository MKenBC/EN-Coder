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

namespace EN_Coder.Forms.Home
{
    public partial class FormLogIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormLogIn()
        {
            InitializeComponent();
        }

        #region MouseClick Event
        private void tbCreateUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbLoginUsername.Text == "Username")
            {
                tbLoginUsername.Clear();
                tbLoginUsername.Focus();
                tbLoginUsername.ForeColor = Color.Black;
            }

            if (tbLoginPass.TextLength == 0)
            {
                tbLoginPass.Text = "Password";
                tbLoginPass.ForeColor = Color.Gray;
                tbLoginPass.PasswordChar = '\0';
            }
        }

        private void tbCreatePass_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbLoginPass.Text == "Password")
            {
                tbLoginPass.Clear();
                tbLoginPass.Focus();
                tbLoginPass.ForeColor = Color.Black;
                tbLoginPass.PasswordChar = '*';
            }

            if (tbLoginUsername.TextLength == 0)
            {
                tbLoginUsername.Text = "Username";
                tbLoginUsername.ForeColor = Color.Gray;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((tbLoginPass.Text != "Password") && (tbLoginPass.Text != ""))
            {
                if (btnShow.Text == "Show")
                {
                    btnShow.Text = "Hide";
                    tbLoginPass.PasswordChar = '\0';
                }
                else
                {
                    btnShow.Text = "Show";
                    tbLoginPass.PasswordChar = '*';
                }
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Question", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pCreateAcc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btmLogIn_Click(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem != null)
            { 
                if (cbRole.SelectedItem.ToString() == "Admin")
                {
                    if ((tbLoginUsername.Text != "Username") && (tbLoginPass.Text != "Password"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("SELECT * FROM owner_table WHERE user_ID = 1", con);

                        SqlDataReader myReader;

                        try
                        {
                            myReader = cmd.ExecuteReader();

                            while (myReader.Read())
                            {

                                string n = myReader.GetString(1);
                                string n1 = myReader.GetString(2);

                                if ((n == tbLoginUsername.Text) && (n1 == tbLoginPass.Text))
                                {
                                    mainForm m1 = new mainForm();
                                    m1.Show();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (cbRole.SelectedItem.ToString() == "Seller")
                {
                    if ((tbLoginUsername.Text != "Username") && (tbLoginPass.Text != "Password"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("SELECT * FROM account_table WHERE Username = @Username", con);
                        cmd.Parameters.AddWithValue("@Username", tbLoginUsername.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataReader myReader;

                        try
                        {
                            myReader = cmd.ExecuteReader();

                            while (myReader.Read())
                            {

                                string n = myReader.GetString(1);
                                string n1 = myReader.GetString(2);

                                if ((n == tbLoginUsername.Text) && (n1 == tbLoginPass.Text))
                                {
                                    Sellers s1 = new Sellers();
                                    s1.myName = n;
                                    s1.Show();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill the Role", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
