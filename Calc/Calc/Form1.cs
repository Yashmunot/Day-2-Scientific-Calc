using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calc
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int no1, no2;
        string op;
        private void button5_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = (sender as Button).Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToInt32(textBox1.Text);
            switch (op)
            {
                case "+":
                    textBox1.Text = (no1 + no2).ToString();
                    break;
                case "-":
                    textBox1.Text = (no1 - no2).ToString();
                    break;
                case "*":
                    textBox1.Text = (no1 * no2).ToString();
                    break;
                case "/":
                    textBox1.Text = (no1 / no2).ToString();
                    break;
               
                case "cos":
                    textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    break;
                case "tan":
                    textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    break;
                
                default:
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             
                    textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = String.Empty;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+(sender as Button).Text;

        }
    }
}
