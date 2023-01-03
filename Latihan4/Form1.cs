using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4
{
    public partial class Form1 : Form
    {
        private int PlaceHolderNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceHolderNumber = PlaceHolderNumber - 5;
            label1.Text = PlaceHolderNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaceHolderNumber = PlaceHolderNumber + 5;
            label1.Text = PlaceHolderNumber.ToString();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1,"Ini Adalah button1");
            toolTip1.SetToolTip(button2, "Ini Adalah button2");
            toolTip1.UseFading = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled |= char.IsLower(e.KeyChar);
            comboBox1.Text = e.Handled.ToString();
           
        }
    }
}
