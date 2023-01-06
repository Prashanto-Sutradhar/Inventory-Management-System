using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class productList : Form
    {
        Product_list cl = new Product_list();
        public productList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl.P_Name = textBox1.Text;
            cl.P_ID = textBox2.Text;
            cl.P_Catagory = textBox3.Text;
            cl.P_Date = textBox4.Text;
            cl.P_Price = textBox5.Text;
            


            bool success = cl.Insert(cl);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");

            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
                MessageBox.Show(cl.message);
            }


            DataTable dt = cl.Select();
            dataGridView1.DataSource = dt;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            cl.P_ID = textBox2.Text;

            bool success = cl.Delete(cl);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");

            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = cl.Select();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cl.P_Name = textBox1.Text;
            cl.P_ID = textBox2.Text;
            cl.P_Catagory = textBox3.Text;
            cl.P_Date = textBox4.Text;
            cl.P_Price = textBox5.Text;


            bool success = cl.Update(cl);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
                MessageBox.Show(cl.message);
            }


            DataTable dt = cl.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            management mg = new management();
            mg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
