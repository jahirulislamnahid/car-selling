using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Selling
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Racing().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cart().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Track().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new Car().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Car().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Audi().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Honda().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lamborgini().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Old().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Parts().Show();
        }


    }
}
