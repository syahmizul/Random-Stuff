using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                int age; 
                bool isAbleToParse = int.TryParse(tb_age.Text,out age);
                if (!isAbleToParse)
                    throw new Exception("Cannot parse the textbox");
                MessageBox.Show("Your age is : " + age.ToString());
                
            }
            catch(Exception exec)
            {
                MessageBox.Show(exec.Message); 
            }
        }
    }
}
