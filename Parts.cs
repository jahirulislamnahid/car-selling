using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Car_Selling
{
    public partial class Parts : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CAR"].ConnectionString;
        public Parts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 040);
            cmd.Parameters.AddWithValue("@product_name", "Battery");
            cmd.Parameters.AddWithValue("@price", 40000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown6.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Battery has been added to your list ");


            }
            else
            {
                MessageBox.Show("Battery has not been added");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 041);
            cmd.Parameters.AddWithValue("@product_name", "Brake");
            cmd.Parameters.AddWithValue("@price", 70000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown5.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Brake has been added to your list ");


            }
            else
            {
                MessageBox.Show("Brake has not been added");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 042);
            cmd.Parameters.AddWithValue("@product_name", "WaterCooler");
            cmd.Parameters.AddWithValue("@price", 100000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown2.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Cooler has been added to your list ");


            }
            else
            {
                MessageBox.Show("Cooler has not been added");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 043);
            cmd.Parameters.AddWithValue("@product_name", "Enginee");
            cmd.Parameters.AddWithValue("@price", 750000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown4.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Enginee has been added to your list ");


            }
            else
            {
                MessageBox.Show("Enginee has not been added");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 044);
            cmd.Parameters.AddWithValue("@product_name", "Handler");
            cmd.Parameters.AddWithValue("@price", 12000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown3.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Handler has been added to your list ");


            }
            else
            {
                MessageBox.Show("Handler has not been added");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 045);
            cmd.Parameters.AddWithValue("@product_name", "RoyalPainting");
            cmd.Parameters.AddWithValue("@price", 200000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Painting has been added to your list ");


            }
            else
            {
                MessageBox.Show("Painting has not been added");

            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
