using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Selling
{
    public partial class Cart : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CAR"].ConnectionString;

        public Cart()
        {
            InitializeComponent();
            BindGridView();
        }

        private void BindGridView()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT Product_Id, Product_Name, Price, Quantity FROM Cart_TBL";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show(); // Change Hide() to Show() to display the Home form
        }

        private void Getdatafromdatabase()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM cart_tbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO CONFIRM YOUR PAYMENT?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new Payment().Show();
            }
            // You might want to handle DialogResult.No and DialogResult.Cancel cases here
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                int Product_ID;
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["ProductIdColumn"].Value.ToString(), out Product_ID))
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM cart_tbl WHERE PRODUCT_ID=@PRODUCT_ID";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@PRODUCT_ID", Product_ID);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Data deleted successfully!!");
                                BindGridView(); // Refresh the grid view after deletion
                            }
                            else
                            {
                                MessageBox.Show("Data not deleted!!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Product ID");
                }
            }
        }

        private void Cart_Activated(object sender, EventArgs e)
        {
            Getdatafromdatabase();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int price = Convert.ToInt32(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                total += price * quantity;
            }
            textBox1.Text = total.ToString();
        }
    }
}
