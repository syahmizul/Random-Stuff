using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int keydown_counter = 0;
        private int keypress_counter = 0;
        private int keyup_counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keydown_counter++;
            label1.Text = keydown_counter.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress_counter++;
            label3.Text = keypress_counter.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyup_counter++;
            label5.Text = keyup_counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
