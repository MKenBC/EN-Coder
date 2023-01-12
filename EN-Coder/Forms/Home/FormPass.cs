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
    public partial class FormPass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public string upDel;
        public FormPass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tbPass.Text = "Password";
            tbPass.ForeColor = Color.Gray;
            tbPass.PasswordChar = '\0';

            this.Hide(); ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != "Password")
            {
                tbPass.Text = "Password";
                tbPass.ForeColor = Color.Gray;
                tbPass.PasswordChar = '\0';
            }
        }

        private void tbPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPass.Text == "Password")
            {
                tbPass.Text = "";
                tbPass.Focus();
                tbPass.ForeColor = Color.Black;
                tbPass.PasswordChar = '*';
            }
        }

        //Drag Form ADD using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnShow_MouseClick(object sender, MouseEventArgs e)
        {
            if ((tbPass.Text != "Password") && (tbPass.Text != ""))
            {
                if (btnShow.Text == "Show")
                {
                    btnShow.Text = "Hide";
                    tbPass.PasswordChar = '\0';
                }
                else
                {
                    btnShow.Text = "Show";
                    tbPass.PasswordChar = '*';
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if ((tbPass.Text != "Password") && (tbPass.TextLength != 0))
            {
                if (upDel == "Update")
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

                            if (n1 == tbPass.Text)
                            {
                                tbPass.Text = "Password";
                                tbPass.ForeColor = Color.Gray;
                                tbPass.PasswordChar = '\0';

                                FormUpdate fu = new FormUpdate();
                                fu.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                    con.Close();
                }
                else if (upDel == "Delete")
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

                            if (n1 == tbPass.Text)
                            {
                                tbPass.Text = "Password";
                                tbPass.ForeColor = Color.Gray;
                                tbPass.PasswordChar = '\0';

                                FormDelete fd = new FormDelete();
                                fd.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
