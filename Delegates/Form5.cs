using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
   
    public partial class Form5 : Form
    {
        delegate void DelegateAddData(List<string> list);

        private void AddData (List<string> list)
        {
            foreach (string name in list)
            {
                comboBox1.Items.Add(name);
            }
        }

        List<string> VetName = new List<string>
        {
           "Dr Wong","Dr Hoang","Dr Hanafi"
        };

        List<string> VetAge = new List<string>
        {
           "25","45","32"
        };



        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DelegateAddData delAddData = AddData;
            delAddData(VetName);
            comboBox1.SelectedIndex = 0;
            label2.Text = "Info :\n" + "Name : " + VetName[comboBox1.SelectedIndex] + "\n" + "Age : " + VetAge[comboBox1.SelectedIndex] + "\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Info :\n" + "Name : " + VetName[comboBox1.SelectedIndex] + "\n" + "Age : " + VetAge[comboBox1.SelectedIndex] + "\n";
        }
    }
}
