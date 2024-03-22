using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string userData = "";
        private AMD amd = new AMD();
        private int[] count = new int[6];
        private List<string> series = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count[0] = (int)numericUpDown1.Value;
            count[1] = (int)numericUpDown2.Value;
            count[2] = (int)numericUpDown3.Value;
            count[3] = (int)numericUpDown4.Value;
            count[4] = (int)numericUpDown5.Value;
            count[5] = (int)numericUpDown6.Value;

            foreach(int i in count)
            {
                if (i != 0)
                {
                    series.Add(amd.series[i]);
                }
            }
            

            int total = amd.total(count);
            textBox2.Text = total.ToString();

            if (int.TryParse(textBox1.Text, out int value1) && int.TryParse(textBox2.Text, out int value2))
            {
                int result = value1 - value2;

                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please put only number");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userData = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            bool can = csv.SavetoFile("AMD", series , count.Sum() , amd.total(count));
            if (can)
            {
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }
    }
}
