using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kv_yravnenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
                }
                if(d == 0)
                {
                    double x=(-b/2*a);
                    MessageBox.Show("Дискриминант равен нулю. Корень равен "+x+".");
                }
                if(d > 0)
                {
               
                double x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                double x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                MessageBox.Show("D = " +d+ ". X1 = "+x1+". x2 = "+x2+".");

                using (StreamWriter w = File.AppendText("log.txt"))
                {
                    w.WriteLine("D = " +d+ ". X1 = "+x1+". x2 = "+x2+".");
                }
            }         
        }
    
    }
   
}
