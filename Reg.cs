using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Selling
{
    public partial class Reg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CAR"].ConnectionString;

        public Reg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Car().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Other event handlers...

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "SELECT * FROM reg_tbl WHERE username=@username AND email=@email AND mobileno=@mobileno AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@email", textBox2.Text);
                        cmd.Parameters.AddWithValue("@mobileno", textBox3.Text);
                        cmd.Parameters.AddWithValue("@password", textBox5.Text);

                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new Login().Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration Unsuccessful", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill up all the boxes", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
