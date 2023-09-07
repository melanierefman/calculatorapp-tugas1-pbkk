using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        decimal num1;
        decimal num2;
        int opr;
        Boolean opr_done = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "0";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            num1 = 0;
            num2 = 0;
            textBox.Text = " ";
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textBox.Text);
            textBox.Text = "*";
            textBox.Text = " ";
            opr = 0;
            opr_done = true;
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textBox.Text);
            textBox.Text = "/";
            textBox.Text = " ";
            opr = 1;
            opr_done = true;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textBox.Text);
            textBox.Text = "+";
            textBox.Text = " ";
            opr = 2;
            opr_done = true;
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textBox.Text);
            textBox.Text = "-";
            textBox.Text = " ";
            opr = 3;
            opr_done = true;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            if(opr_done == true)
                num2 = Convert.ToDecimal(textBox.Text);
            {
                switch (opr)
                {
                    case 0:
                        textBox.Text = Convert.ToString(num1 * num2);
                        break;
                    case 1:
                        textBox.Text = Convert.ToString(num1 / num2);
                        break;
                    case 2:
                        textBox.Text = Convert.ToString(num1 + num2);
                        break;
                    case 3:
                        textBox.Text = Convert.ToString(num1 - num2);
                        break;
                }
                opr_done = false;
            }
        } 
    }
}
