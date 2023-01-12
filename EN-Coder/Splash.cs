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
using EN_Coder.Forms.Home;

namespace EN_Coder
{
    public partial class Splash : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pLoad.Width += 3;

            if (pLoad.Width > 700)
            {
                timer1.Stop();
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM owner_table", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if ((dt.Rows.Count > 0) && (dt.Rows[0][0] != DBNull.Value))
                {
                    FormLogIn f1 = new FormLogIn();
                    f1.Show();
                }
                else
                {
                    FormSignIn f2 = new FormSignIn();
                    f2.Show();
                }

                con.Close();

                this.Hide();
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Question", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
