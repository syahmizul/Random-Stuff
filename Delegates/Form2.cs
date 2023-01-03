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
    public partial class Form2 : Form
    {
        delegate void DelegateOneString(string str);
        delegate void DelegateInformation(string str);
        string appDate;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label5.Enabled = false;
        }

        private void PrintName(string name)
        {
            label5.Text += $"\n{name}";
        }

        DelegateInformation DisplayInfo = delegate (string info)
        {
            MessageBox.Show(info);
        };

        private void button2_Click(object sender, EventArgs e)
        {
            DelegateOneString Print = PrintName;
            
            Print("Owner : " + textBox1.Text);
            Print("Cat : " + textBox2.Text);
            Print("Breed : " + comboBox1.SelectedItem);
            Print("Appointment Date : " + appDate);
            label5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;

            DisplayInfo("Appointment has been set.");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            appDate = e.Start.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            label5.Enabled = false;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label5.Text = string.Empty;
            label5.Text = "Appointment Details:";
            DisplayInfo("Reset form to record New Appointment.");
        }
    }
}
