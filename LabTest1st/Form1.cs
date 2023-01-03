using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1st
{
    public partial class Form1 : Form
    {
        private float[][] Sizes = new float[3][];
        private int amountrequired;
                                
        public Form1()
        {
            InitList();
            InitializeComponent();
        }

        //0 - feet , 1 - inch
        public float NormalizeToM(int type,float num)
        {
            
            float result = 1;
            
            switch(type)
            {
                case 0:
                    result = num / 3.281F;
                    break;
                case 1:
                    
                    result = num / 39.97F;
                    break;
                default:
                    break;
            }
            return result;
        }

        public void InitList()
        {

            Sizes[0] = new float[] { NormalizeToM(1, 21F), NormalizeToM(0, 50F), 116.50F };
            Sizes[1] = new float[] { NormalizeToM(1, 27F), NormalizeToM(0, 50F), 125.50F };
            Sizes[2] = new float[] { NormalizeToM(1, 42F), NormalizeToM(0, 50F), 150.50F };

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = "RM" + Sizes[comboBox2.SelectedIndex][2].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            try
            {
                label13.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }

                label10.Text = textBox2.Text;
            try
            {
                label13.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
            label15.Text = (Sizes[comboBox2.SelectedIndex][0] * Sizes[comboBox2.SelectedIndex][1]).ToString();
            if ((Sizes[comboBox2.SelectedIndex][0] * Sizes[comboBox2.SelectedIndex][1]) >= (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)))
            {
                label14.Text = "IsEnough";
            }
            else
            {
                label14.Text = "IsNotEnough";
                for (int i = 1; i <= 100; i++)
                {
                    float wallpapersize = (Sizes[comboBox2.SelectedIndex][0] * Sizes[comboBox2.SelectedIndex][1]);
                    if ((int.Parse(textBox1.Text) * int.Parse(textBox2.Text)) <= Math.Pow(wallpapersize,i))
                    {
                        label17.Text = i.ToString();
                    }

                }
            }
            

        }
    }
}
