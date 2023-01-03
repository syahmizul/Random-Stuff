using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {

        List<int> markahKuiz = new List<int> { 10, 15, 18, 17, 19, 16 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int no in markahKuiz)
                listBoxMarkah.Items.Add(no);
        }

        private void buttonBesar14_Click(object sender, EventArgs e)
        {
            labelLebih14.Text = string.Empty;
            IEnumerable<int> lebihBesar14 = markahKuiz.Where(markah => markah > 14).OrderBy(markah => markah).ToList();
            int[] mark = lebihBesar14.ToArray();
            //labelLebih14.Text += mark[2] + "\n";

            foreach (int markah in mark)
                labelLebih14.Text += markah + "\n";

            /*labelLebih14.Text = string.Empty;

            foreach (int markah in lebihBesar14)
                labelLebih14.Text += markah + "\n";*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Latihan A
            IEnumerable<int> lebihBesar = markahKuiz.Where(markah => markah > int.Parse(textBox1.Text)).OrderBy(markah => markah);

            //Latihan B
            int bil =
                (from markah in markahKuiz
                 where markah > int.Parse(textBox1.Text)
                 select markah).Count();

            label3.Text = string.Empty;
            label9.Text = bil.ToString();
            foreach (int markah in lebihBesar)
                label3.Text += markah + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lebihBesar14 =
                from markah in markahKuiz
                where markah > 14 && markah % 2 == 1
                orderby markah
                select markah;

            label5.Text = string.Empty;

            foreach (int markah in lebihBesar14)
                label5.Text += markah + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lebihBesar14 =
                from markah in markahKuiz
                where markah > 14 && markah % 2 == 0
                orderby markah
                select markah;

            label7.Text = string.Empty;

            foreach (int markah in lebihBesar14)
                label7.Text += markah + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var isih =
                from markah in markahKuiz
                orderby markah
                select markah;

            listBoxMarkah.Items.Clear();

            foreach (int no in isih)
                listBoxMarkah.Items.Add(no);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var isih =
                from markah in markahKuiz
                orderby markah descending
                select markah;

            listBoxMarkah.Items.Clear();

            foreach (int no in isih)
                listBoxMarkah.Items.Add(no);
        }

        private void buttonLinq_Click(object sender, EventArgs e)
        {
            labelLinq.Text = string.Empty;

            labelLinq.Text += "Max: " + markahKuiz.Max();
            labelLinq.Text += "\nMin: " + markahKuiz.Min();
            labelLinq.Text += "\nJumlah: " + markahKuiz.Sum();
            labelLinq.Text += "\nPurata: " + markahKuiz.Average();

            markahKuiz.Sort();
            labelLinq.Text += "\nIsih menaik: ";
            markahKuiz.ForEach(n => labelLinq.Text += "\n" + n);

            markahKuiz.Reverse();
            labelLinq.Text += "\nIsih menurun: ";
            markahKuiz.ForEach(n => labelLinq.Text += "\n" + n);

            labelLinq.Text += "\nBilangan elemen: " + markahKuiz.Count();

        }
    }
}
