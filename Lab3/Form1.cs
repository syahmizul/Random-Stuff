using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Items.RemoveAt((int)numericUpDown1.Value - 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch(comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"Berat {comboBox1.SelectedItem} adalah 5kg");
                    break;
                case 1:
                    MessageBox.Show($"Berat {comboBox1.SelectedItem} adalah 12kg");
                    break;
                case 2:
                    MessageBox.Show($"Berat {comboBox1.SelectedItem} adalah 36kg");
                    break;
                default:
                    MessageBox.Show($"Berat {comboBox1.SelectedItem} adalah 0.3kg");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Valid range 0-4 ,any other value will generate out of range exceptions
            if (textBox1.Text != "")
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show($"{textBox1.Text} telah sedia ada dalam combobox");
                }
                else
                    comboBox1.Items.Insert(0, textBox1.Text);
            }
            else
                MessageBox.Show("Text box is empty!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show($"{radioButton1.Text} dipilih");
            else
                MessageBox.Show($"{radioButton2.Text} dipilih");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                MessageBox.Show($"{radioButton3.Text} dipilih");
            else
                MessageBox.Show($"{radioButton4.Text} dipilih");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<String> placeholder1 = new List<String>{ }; //temporary array to store checked button's text
            String endresult = "";
            if (radioButton1.Checked)
                placeholder1.Add(radioButton1.Text);
            if (radioButton2.Checked)
                placeholder1.Add(radioButton2.Text);
            if (radioButton3.Checked)
                placeholder1.Add(radioButton3.Text);
            if (radioButton4.Checked)
                placeholder1.Add(radioButton4.Text);
            int count = 0;
            //loop through the stored texts and keep adding "and" in between each elements except for the last element
            foreach (String key in placeholder1) 
            {
                endresult += key; // store in endresult 
                if (count != placeholder1.Count - 1) //stop when count reaches the number of elements
                    endresult += " and ";
                count++;
            }

            endresult += " dipilih.";
            MessageBox.Show(endresult);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String menu = " ";
            float[] Price = { 3.00F, 1.50F, 0.50F, 0.20F };
            float Total = 0;
            if (checkedListBox1.CheckedItems.Count != 0)
            { 
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if(checkedListBox1.GetItemChecked(i))
                    {
                            menu += "\n" + checkedListBox1.Items[i].ToString();
                            Total += Price[i];
                    }
                    
                }
            }

            MessageBox.Show($"Pilihan \n {menu}\nTotal: RM {Total.ToString("F2")}");
        }
    }
}
