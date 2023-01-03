using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private bool isFlipped = false;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(isFlipped)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
               
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            isFlipped = !isFlipped;
            if (isFlipped)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            counter++;
            label2.Text = counter.ToString() + " time.";

        }
    }
}
