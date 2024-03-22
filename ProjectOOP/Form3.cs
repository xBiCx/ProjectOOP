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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Nvidia nvidia = new Nvidia();
        int[] count = new int[6];
        List<string> series = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
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

            foreach (int i in count)
            {
                if (i != 0)
                {
                    series.Add(nvidia.series[i]);
                }
            }

            int total = nvidia.total(count);
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            bool can = csv.SavetoFile("Nvidia", series, count.Sum(), nvidia.total(count));
            if (can)
            {
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
