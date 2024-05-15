using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Selling
{
    public partial class Payment : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CAR"].ConnectionString;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cart().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from payment_tbl where accmob=@accmob and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accmob", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Payment is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Home().Show();

                }
                else
                {
                    MessageBox.Show("Payment Unsuccessful", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    con.Close();
                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payment_Successful().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from address_tbl where FLAT_NO=@FLAT_NO and HOUSE_NO=@HOUSE_NO and AREA=@AREA and CITY=@CITY";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FLAT_NO", textBox3.Text);
                cmd.Parameters.AddWithValue("@HOUSE_NO", textBox4.Text);
                cmd.Parameters.AddWithValue("@AREA", textBox5.Text);
                cmd.Parameters.AddWithValue("@CITY", textBox6.Text);


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Address provided Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("ADDRESS NOT PROVIDED PROPERLY", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill up all the boxes", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO PAY THROUGH VISA?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fill up the  card details");

            }
            else if (result == DialogResult.No)
            {
                this.Close();
                new Payment().Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO PAY THROUGH MASTER CARD?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fill up the  card details");

            }
            else if (result == DialogResult.No)
            {
                this.Close();
                new Payment().Show();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO PAY THROUGH NEXUS PAY?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fill up the  card details");
            }
            else if (result == DialogResult.No)
            {

                this.Close();
                new Payment().Show();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO PAY THROUGH BKASH ?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fill up the account details");
            }
            else if (result == DialogResult.No)
            {
                this.Close();
                new Payment().Show();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO PAY THROUGH NOGOD?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fill up the account details");
            }
            else if (result == DialogResult.No)
            {

                this.Close();
                new Payment().Show();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.Icon = Properties.Resources.error;
                errorProvider3.SetError(this.textBox3, "Fill up the box!");

            }
            else
            {
                errorProvider3.Icon = Properties.Resources.check;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.Icon = Properties.Resources.error;
                errorProvider4.SetError(this.textBox4, "Fill up the box!");

            }
            else
            {
                errorProvider4.Icon = Properties.Resources.check;
            }

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox5.Focus();
                errorProvider5.Icon = Properties.Resources.error;
                errorProvider5.SetError(this.textBox5, "Fill up the box!");

            }
            else
            {
                errorProvider5.Icon = Properties.Resources.check;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text) == true)
            {
                textBox6.Focus();
                errorProvider6.Icon = Properties.Resources.error;
                errorProvider6.SetError(this.textBox6, "Fill up the box!");

            }
            else
            {
                errorProvider6.Icon = Properties.Resources.check;
            }
        }
    }
}
