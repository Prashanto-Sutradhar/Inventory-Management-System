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
    public partial class order : Form
    {
        Order1 o = new Order1();
        public order()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o.ProductName = textBox1.Text;
            o.ProductID = textBox2.Text;
            o.Price = textBox3.Text;
            o.OrderDate = textBox4.Text;
            o.ArrivalDate = textBox5.Text;



            bool success = o.Insert(o);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");

            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
                MessageBox.Show(o.message);
            }


            DataTable dt = o.Select();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
