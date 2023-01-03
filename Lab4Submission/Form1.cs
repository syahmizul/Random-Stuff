using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Submission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.RemoveAt(0);
            }
            catch(ArgumentOutOfRangeException exec)
            {
                comboBox1.Enabled = false;
                button1.Enabled = false;
            }
            
        }
        String[] kucingArr = new string[3];
        int idx = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                kucingArr[idx] = textBox1.Text;
                textBox2.Text += kucingArr[idx] + "\r\n";
                idx++;
            }
            catch(IndexOutOfRangeException exec)
            {
                MessageBox.Show($"{exec.ToString()}");
            }

            
        }

        private void ValidateInput(TextBox textbox)
        {

            try 
            {
               if (int.Parse(textbox.Text) < 18)
                    throw new AgeException();
                
            }
            //Parse function throws FormatException
            catch (FormatException) 
            {
                // Use our own Exception when FormatException caught
                throw new NaNException(); 
            }
           
                
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput(textBox3);
            }
            catch(AgeException exec)
            {
                MessageBox.Show(exec.Message);
            }
            //ValidateInput throws NanException instead of FormatException
            catch (NaNException exec)
            {
                MessageBox.Show(exec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // Make use of parse to verify our first textbox is a number
                    int.Parse(tb_firstdivnum.Text); 

                    if (int.Parse(tb_secdivnum.Text) == 0)
                        throw new DivideByZeroException();
                }
                catch(FormatException)
                {
                    //Prioritize using our own Exception
                    throw new NaNException(); 
                }

            }
            catch(DivideByZeroException exec)
            {
                MessageBox.Show(exec.Message);
            }
            catch(NaNException exec)
            {
                MessageBox.Show(exec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != "kucing")
                    throw new KucingValidation();
                else
                    MessageBox.Show("Input is kucing");
            }
            catch(KucingValidation exec)
            {
                MessageBox.Show(exec.Message);
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value <= 0)
                    throw new NaturalNumberException();
            }
            catch(NaturalNumberException exec)
            {
                MessageBox.Show(exec.Message);
            }
        }
    }
}
