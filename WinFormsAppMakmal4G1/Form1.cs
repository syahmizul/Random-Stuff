using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMakmal4G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void semakUmur(int umur)
        {
            if (umur < 18)
            {
                throw new InvalidHadUmur();
                
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                semakUmur(int.Parse(textBox1.Text));
            }
            catch(InvalidHadUmur exec)
            {
                MessageBox.Show(exec.Message);
            }
            
        }
    }
}
