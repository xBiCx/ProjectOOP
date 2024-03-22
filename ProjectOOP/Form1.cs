using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 form2 ;
        private Form3 form3 ;
        private Form4 form4 ;
        private CSV csv = new CSV();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            form4 = new Form4();
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
