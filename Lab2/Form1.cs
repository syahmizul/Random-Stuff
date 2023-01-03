using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if(e.KeyChar == (char)Keys.Enter)
            {
                {
                    int num1 = 0,
                        num2 = 0;
                    int.TryParse(textBox1.Text, out num1);
                    int.TryParse(textBox2.Text, out num2);
                    label9.Text = (num1 + num2).ToString();
                }

                {
                    int num1 = 0,
                        num2 = 0;
                    int.TryParse(textBox4.Text, out num1);
                    int.TryParse(textBox3.Text, out num2);
                    label10.Text = Math.Abs((num1 - num2)).ToString();
                }

                {
                    int num1 = 0,
                        num2 = 0;
                    int.TryParse(textBox6.Text, out num1);
                    int.TryParse(textBox5.Text, out num2);
                    label11.Text = (num1 * num2).ToString();
                }

                {
                    int num1 = 0,
                        num2 = 0;
                    int.TryParse(textBox8.Text, out num1);
                    int.TryParse(textBox7.Text, out num2);
                    if (num2 != 0)
                        label12.Text = (num1 / num2).ToString();
                    else
                        label12.Text = "0";
                }
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0,
                num2 = 0;
            int.TryParse(textBox1.Text, out num1);
            int.TryParse(textBox2.Text,out num2);
            label9.Text = (num1+num2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 0,
                num2 = 0;
            int.TryParse(textBox4.Text, out num1);
            int.TryParse(textBox3.Text, out num2);
            label10.Text = Math.Abs((num1 - num2)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = 0,
                num2 = 0;
            int.TryParse(textBox6.Text, out num1);
            int.TryParse(textBox5.Text, out num2);
            label11.Text = (num1 * num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 0,
                num2 = 0;
            int.TryParse(textBox8.Text, out num1);
            int.TryParse(textBox7.Text, out num2);
            label12.Text = (num1 / num2).ToString();
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if ( textBox7.Text == "0")
            {
                MessageBox.Show("Invalid input");
                textBox7.Text = "";
            }
        }

        private void numericUpDownLine1(object sender, EventArgs e)
        {
            label25.Text = (numericUpDown1.Value + numericUpDown2.Value).ToString();
        }
        private void numericUpDownLine2(object sender, EventArgs e)
        {
            label26.Text = (numericUpDown3.Value - numericUpDown4.Value).ToString();
        }
        private void numericUpDownLine3(object sender, EventArgs e)
        {
            label27.Text = (numericUpDown5.Value * numericUpDown6.Value).ToString();
        }
        private void numericUpDownLine4(object sender, EventArgs e)
        {
            if(numericUpDown8.Value != 0)
                label28.Text = (numericUpDown7.Value / numericUpDown8.Value).ToString();
        }
    }
}
