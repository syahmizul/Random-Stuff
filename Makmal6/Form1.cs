using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Makmal6
{
    public partial class Form1 : Form
    {
        private string[] namaKucing = new string[5];
        private int bil = 0;
        private List<string> namaKucingList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Latihan A
            //2.
            try
            {
                if (bil >= namaKucing.Length)//Check the loop counter before anything else
                    throw new Exception("Can't add anymore,array space is not enough.");//throws exception here
                namaKucing[bil] = textBox1.Text;
                listBox1.Items.Add(namaKucing[bil]);
                bil++;
            }
            catch (Exception exec)//catches exception here
            {
                MessageBox.Show(exec.Message);
            }

        }

        public void Senarai(int[] array, ListBox lb)
        {
            for (int i = 0; i < array.Length; i++)
            {
                lb.Items.Add(array[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] kumpulanNo = { 10, 20, 30, 40, 50, 60 };
            //int hasilCampur = 0;

            //foreach(int noSatuPerSatu in kumpulanNo)
            //{
            //hasilCampur += noSatuPerSatu;
            //}

            /*Latihan B
            1.
            for (int i = 0; i < kumpulanNo.Length; i++)
            {
                listBox1.Items.Add(kumpulanNo[i]);
            }
            Latihan B
            2.
            foreach (int i in kumpulanNo)
            {
                listBox1.Items.Add(i);
            }
            */
            //Latihan B
            //3.
            Senarai(kumpulanNo, listBox1);
            //MessageBox.Show($"Hasil campur {kumpulanNo.Length} nombor adalah {hasilCampur} \n\r");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] markah = {
                          { 71,67,45,82 },
                          { 54,87,90,68 },
                          { 80,75,39,61 }
                        };
            label5.Text = $"{markah.Length}";
            label6.Text = $"{markah.GetLength(0)}";
            label7.Text = $"{markah.GetLength(1)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] markah = {
                          { 71,67,45,82 },
                          { 54,87,90,68 },
                          { 80,75,39,61 }
                        };
            

            for (int baris = 0; baris < markah.GetLength(0); baris++)
            {
                for(int lajur = 0;lajur < markah.GetLength(1);lajur++)
                {
                    listBox2.Items.Add(markah[baris, lajur].ToString());
                }
            }

            label9.Text = "";
            
            for (int baris = 0; baris < markah.GetLength(0); baris++)
            {

                for (int lajur = 0; lajur < markah.GetLength(1); lajur++)
                {
                    label9.Text += markah[baris , lajur].ToString() + "  ";;
                }
                label9.Text += "\n\r";
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[][] jagArr = new int[3][];
            jagArr[0] = new int[4] { 1, 2, 3, 4 };
            jagArr[1] = new int[3] { 5, 6, 7 };
            jagArr[2] = new int[5] { 8, 9, 10, 11, 12 };
            label11.Text = "";
            for (int baris = 0; baris < jagArr.Length; baris++)
            {

                for (int lajur = 0; lajur < jagArr[baris].Length; lajur++)
                {
                    label11.Text += jagArr[baris][lajur].ToString() + "  "; ;
                }
                label11.Text += "\n\r";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            namaKucingList.Add(textBox2.Text);
            label13.Text = "";

            for(int i = 0;i<namaKucingList.Count;i++)
            {
                label13.Text += namaKucingList[i] + "\n\r";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            namaKucingList.Remove(textBox2.Text);
            label13.Text = "";
            for (int i = 0; i < namaKucingList.Count; i++)
            {
                label13.Text += namaKucingList[i] + "\n\r";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            namaKucingList.Insert(0,textBox2.Text);
            label13.Text = "";
            for (int i = 0; i < namaKucingList.Count; i++)
            {
                label13.Text += namaKucingList[i] + "\n\r";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            namaKucingList.RemoveAt(0);
            label13.Text = "";
            for (int i = 0; i < namaKucingList.Count; i++)
            {
                label13.Text += namaKucingList[i] + "\n\r";
            }
        }
    }
}
//Latihan A
// 1. Akan berlaku exception.