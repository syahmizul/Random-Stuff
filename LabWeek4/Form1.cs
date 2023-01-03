using System;
using System.Windows.Forms;

namespace LabWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                int result = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                label3.Text = $"{result}";
            }
            
            catch (FormatException exec)
            {
                MessageBox.Show(exec.Message + "Input mestilah nombor");


            }
            catch (DivideByZeroException exec)
            {
                MessageBox.Show(exec.Message + "Nombor kedua mestilah nilai selain 0");
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
            finally 
            {
                MessageBox.Show("Sentiasa");
            }*/
            int numeration, denumeration;
            bool no1 = int.TryParse(textBox1.Text, out numeration);
            bool no2 = int.TryParse(textBox2.Text, out denumeration);
            int result = 0;
            if (no1 && no2)
            {
                result = numeration / denumeration;
                label3.Text = $"{result.ToString()}";
            }
            else
                MessageBox.Show("Input hendaklah nombor");


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            comboBoxNamaKucing.Items.RemoveAt(0);
        }

        String[] namaKucing = new String[3];
        int index = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            namaKucing[index] = textBox3.Text;
            textBox4.Text += "\n" + namaKucing[index];
            index++;
        }
    }
}
