using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameClass program = new GameClass();
            program.SetGameSpeed(trackBar1.Value);
            program.OnCreate();
            MessageBox.Show("Game Over!");
            label2.Text = "Score : " + program.score; 
        }

        
    }
}
