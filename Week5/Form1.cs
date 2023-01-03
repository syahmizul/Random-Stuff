using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        Account akaun1 = new Account();
        AutoAccount autoacc = new AutoAccount();
        LatihanD latihanD = new LatihanD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Latihan A
            akaun1.SetNama(textBox1.Text);
            label4.Text = akaun1.GetNama();
            akaun1.SetJantina(textBox3.Text);
            label9.Text = akaun1.GetJantina();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Latihan B
            akaun1.Nama = textBox4.Text;
            label12.Text = akaun1.Nama;
            akaun1.Jantina = textBox2.Text;
            label6.Text = akaun1.Jantina;
        }

        //Latihan C
        private void button3_Click(object sender, EventArgs e)
        {
            autoacc.Nama = textBox6.Text;
            label19.Text = autoacc.Nama;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label19.Text = autoacc.Nama; //default value
        }

        private void button6_Click(object sender, EventArgs e)
        {
            latihanD.Nama = textBox5.Text;
            latihanD.strBaki = textBox7.Text;
            try
            {
                latihanD.intBakiAwal = int.Parse(latihanD.strBaki);
            }
            catch(FormatException)
            {
                MessageBox.Show("Baki TextBox is not a number.");
            }
            

            label17.Text = latihanD.Nama;
            label25.Text = latihanD.strBaki;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            latihanD.Deposit(int.Parse(textBox8.Text));
            label28.Text = (latihanD.intBakiAwal + latihanD.intBaki).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                latihanD.Withdraw(int.Parse(textBox9.Text), latihanD.intBakiAwal + latihanD.intBaki);
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
            label28.Text = (latihanD.intBakiAwal + latihanD.intBaki).ToString();
        }
    }
}
