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
    public partial class FormSignIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormSignIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Question", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #region MouseClick Event
        private void tbCreateUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbCreateUserName.Text == "Username")
            {
                tbCreateUserName.Clear();
                tbCreateUserName.Focus();
                tbCreateUserName.ForeColor = Color.Black;
            }

            if (tbCreateCompanyName.TextLength == 0)
            {
                tbCreateCompanyName.Text = "Company Name";
                tbCreateCompanyName.ForeColor = Color.Gray;
            }

            if (tbCreatePass.TextLength == 0)
            {
                tbCreatePass.Text = "Password";
                tbCreatePass.ForeColor = Color.Gray;
                tbCreatePass.PasswordChar = '\0';
            }
        }

        private void tbCreatePass_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbCreatePass.Text == "Password")
            {
                tbCreatePass.Clear();
                tbCreatePass.Focus();
                tbCreatePass.ForeColor = Color.Black;
                tbCreatePass.PasswordChar = '*';
            }

            if (tbCreateUserName.TextLength == 0)
            {
                tbCreateUserName.Text = "Username";
                tbCreateUserName.ForeColor = Color.Gray;
            }

            if (tbCreateCompanyName.TextLength == 0)
            {
                tbCreateCompanyName.Text = "Company Name";
                tbCreateCompanyName.ForeColor = Color.Gray;
            }
        }

        private void tbCreateCompanyName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbCreateCompanyName.Text == "Company Name")
            {
                tbCreateCompanyName.Clear();
                tbCreateCompanyName.Focus();
                tbCreateCompanyName.ForeColor = Color.Black;
            }

            if (tbCreateUserName.TextLength == 0)
            {
                tbCreateUserName.Text = "Username";
                tbCreateUserName.ForeColor = Color.Gray;
            }

            if (tbCreatePass.TextLength == 0)
            {
                tbCreatePass.Text = "Password";
                tbCreatePass.ForeColor = Color.Gray;
                tbCreatePass.PasswordChar = '\0';
            }
        }
        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((tbCreatePass.Text != "Password") && (tbCreatePass.Text != ""))
            {
                if (btnShow.Text == "Show")
                {
                    btnShow.Text = "Hide";
                    tbCreatePass.PasswordChar = '\0';
                }
                else
                {
                    btnShow.Text = "Show";
                    tbCreatePass.PasswordChar = '*';
                }
            }
        }

        //Drag Form ADD using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pCreateAcc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btmSignIn_Click(object sender, EventArgs e)
        {
            if ((tbCreateUserName.Text != "Username") && (tbCreatePass.Text != "Password")
                && (tbCreateCompanyName.Text != "Company Name"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO owner_table(user_ID, username, password, companyName)" +
                        " VALUES (@user_ID, @username, @password, @companyName)", con);

                    cmd.Parameters.AddWithValue("@user_ID", 1);
                    cmd.Parameters.AddWithValue("@username", tbCreateUserName.Text);
                    cmd.Parameters.AddWithValue("@password", tbCreatePass.Text);
                    cmd.Parameters.AddWithValue("@companyName", tbCreateCompanyName.Text);
                    cmd.ExecuteNonQuery();

                    FormLogIn f1 = new FormLogIn();
                    f1.Show();

                    MessageBox.Show("Account has been created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    this.Close();
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
