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

namespace EN_Coder.Forms
{
    public partial class FormGStatistics : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        public FormGStatistics()
        {
            InitializeComponent();
            SoldCount();
            Stocks();
            ResellersCount();
            ItemCount();
            TotalIncome();
            TotalExpense();
        }

        private void SoldCount()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM encode_table", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n += myReader.GetInt32(5);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lSoldCount.Text = n.ToString();
            con.Close();
        }

        private void Stocks()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_total", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n += myReader.GetInt32(2);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lStocks.Text = n.ToString();
            con.Close();
        }

        private void ResellersCount()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM resellers_info", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lResellersCount.Text = n.ToString();
            con.Close();
        }

        private void ItemCount()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM products_info", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lItemCount.Text = n.ToString();
            con.Close();
        }

        private void TotalIncome()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM cash_income", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n += myReader.GetInt32(1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lTotalIncome.Text = n.ToString();
            con.Close();
        }

        private void TotalExpense()
        {
            int n = 0;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM cash_expense", con);

            SqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    n += myReader.GetInt32(1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            lTotalExpence.Text = n.ToString();
            con.Close();
        }
    }
}
