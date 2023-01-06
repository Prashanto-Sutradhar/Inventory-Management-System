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
    public partial class catagory : Form
    {
        Catagories cg = new Catagories();
        public catagory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cg.P_Catagory = textBox1.Text;
            cg.P_Quantity = textBox2.Text;
            



            bool success = cg.Insert(cg);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");

            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
                //MessageBox.Show(cg.message);
            }


            DataTable dt = cg.Select();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cg.P_Catagory = textBox1.Text;

            bool success = cg.Delete(cg);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");

            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = cg.Select();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cg.P_Catagory = textBox1.Text;
            cg.P_Quantity = textBox2.Text;
            


            bool success = cg.Update(cg);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
                //MessageBox.Show(cl.message);
            }


            DataTable dt = cg.Select();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void catagory_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            management mg = new management();
            mg.Show();
        }
    }
}
