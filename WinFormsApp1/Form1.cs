using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int CenterNumber = 0;
        private int[] NumberArray = {};
        public Form1()
        {
            InitializeComponent();
        }
        /* int TempInteger = 0;
            textBox1.Text = "";
            for(int i = 0;i<NumberArray.Max();i++)
            {
                TempInteger += NumberArray[i];
            }
            label1.Text = TempInteger.ToString();*/
        /*textBox1.Text = "";
            NumberArray.Append(Int32.Parse(textBox1.Text));*/
        private void button1_Click(object sender, EventArgs e)
        {
            CenterNumber = CenterNumber - 5;
            label1.Text = CenterNumber.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CenterNumber = CenterNumber + 5;
            label1.Text = CenterNumber.ToString();
        }

        

    }
}
