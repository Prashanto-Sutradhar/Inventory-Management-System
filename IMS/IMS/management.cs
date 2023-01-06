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
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productList pl = new productList();
            pl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            catagory c = new catagory();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*order o = new order();
            o.Show();*/
            this.Hide();
            MessageBox.Show("work ongoing");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            administration a = new administration();
            a.Show();
            this.Hide();
        }
    }
}
