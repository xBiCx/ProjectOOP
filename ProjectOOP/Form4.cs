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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Intel intel = new Intel();
        int[] count = new int[4];
        List<string> series = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count[0] = (int)numericUpDown1.Value;
            count[1] = (int)numericUpDown2.Value;
            count[2] = (int)numericUpDown3.Value;
            count[3] = (int)numericUpDown4.Value;

            foreach (int i in count)
            {
                if (i != 0)
                {
                    series.Add(intel.series[i]);
                }
            }


            int total = intel.total(count);
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            bool can = csv.SavetoFile("Intel", series, count.Sum(), intel.total(count));
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
