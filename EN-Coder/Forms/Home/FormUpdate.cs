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
    
    public partial class FormUpdate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormUpdate()
        {
            InitializeComponent();

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM owner_table WHERE user_ID = 1", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    tbUserName.Text = myReader.GetString(1);
                    tbPass.Text = myReader.GetString(2);
                    tbPass.PasswordChar = '*';
                    tbCompanyName.Text = myReader.GetString(3);

                    tbUserName.ForeColor = tbPass.ForeColor = tbCompanyName.ForeColor = Color.Black;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((tbPass.Text != "New Password") && (tbPass.Text != ""))
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

        private void tbUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbUserName.Text == "New Username")
            {
                tbUserName.Clear();
                tbUserName.Focus();
                tbUserName.ForeColor = Color.Black;
            }

            if (tbCompanyName.TextLength == 0)
            {
                tbCompanyName.Text = "New Company Name";
                tbCompanyName.ForeColor = Color.Gray;
            }

            if (tbPass.TextLength == 0)
            {
                tbPass.Text = "New Password";
                tbPass.ForeColor = Color.Gray;
                tbPass.PasswordChar = '\0';
            }
        }

        private void tbPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPass.Text == "New Password")
            {
                tbPass.Clear();
                tbPass.Focus();
                tbPass.ForeColor = Color.Black;
                tbPass.PasswordChar = '*';
            }

            if (tbUserName.TextLength == 0)
            {
                tbUserName.Text = "New Username";
                tbUserName.ForeColor = Color.Gray;
            }

            if (tbCompanyName.TextLength == 0)
            {
                tbCompanyName.Text = "New Company Name";
                tbCompanyName.ForeColor = Color.Gray;
            }
        }

        private void tbCompanyName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbCompanyName.Text == "New Company Name")
            {
                tbCompanyName.Clear();
                tbCompanyName.Focus();
                tbCompanyName.ForeColor = Color.Black;
            }

            if (tbUserName.TextLength == 0)
            {
                tbUserName.Text = "New Username";
                tbUserName.ForeColor = Color.Gray;
            }

            if (tbPass.TextLength == 0)
            {
                tbPass.Text = "New Password";
                tbPass.ForeColor = Color.Gray;
                tbPass.PasswordChar = '\0';
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

        private void FormUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btmUpdate_Click(object sender, EventArgs e)
        {
            if ((tbUserName.Text != "New Username") && (tbUserName.TextLength != 0)
                && (tbPass.Text != "New Password") && (tbPass.TextLength != 0)
                && (tbCompanyName.Text != "New Company Name") && (tbCompanyName.TextLength != 0))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE owner_table SET username = @username, " +
                        "password = @password, companyName = @companyName WHERE user_ID = 1", con);

                    cmd.Parameters.AddWithValue("@username", tbUserName.Text);
                    cmd.Parameters.AddWithValue("@password", tbPass.Text);
                    cmd.Parameters.AddWithValue("@companyName", tbCompanyName.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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
    }
}
