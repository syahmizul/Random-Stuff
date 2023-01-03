using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10CandD
{
    public partial class Form1 : Form
    {
        List<Pelajar> pel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pel = new List<Pelajar>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string noMatrik = textBox2.Text;
            int markah = int.Parse(textBox3.Text);
            int umur = int.Parse(textBox4.Text);
            pel.Add(new Pelajar(nama, noMatrik, markah,umur));

            label4.Text = string.Empty + "Senarai pelajar:\n";

            foreach(Pelajar p in pel)
            {
                label4.Text += p.ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pelLemah =
                from lemah in pel
                where lemah.Markah < 50
                select lemah.Nama;

            label5.Text = string.Empty + "Senarai pelajar lemah:\n";

            foreach (var pl in pelLemah)
                label5.Text += pl + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pelUmur =
                from pelajar in pel
                where pelajar.Umur <= 24 && pelajar.Umur >= 19
                select pelajar;

            label7.Text = string.Empty + "Senarai pelajar 19 hingga 24:\n";

            foreach (var pl in pelUmur)
                label7.Text += pl + "\n";
        }
    }
}
