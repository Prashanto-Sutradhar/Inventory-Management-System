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
    public partial class administration : Form
    {
        Adminis a = new Adminis();
        public administration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.ID = textBox1.Text;
            a.Name = textBox2.Text;
            a.Number = textBox3.Text;
            a.Address = textBox4.Text;
            a.Email = textBox5.Text;



            bool success = a.Insert(a);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");

            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
                //MessageBox.Show(a.message);
            }


            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            a.ID = textBox1.Text;

            bool success = a.Delete(a);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");

            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.ID = textBox1.Text;
            a.Name = textBox2.Text;
            a.Number = textBox3.Text;
            a.Address = textBox4.Text;
            a.Email = textBox5.Text;


            bool success = a.Update(a);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
               // MessageBox.Show(a.message);
            }


            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            management mg = new management();
            mg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
