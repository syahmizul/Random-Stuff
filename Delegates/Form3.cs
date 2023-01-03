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
    delegate string Delegate3Decimal(decimal w, decimal o, decimal u);

    public partial class Form3 : Form
    {
        List<string> catBreed = new List<string>
        { "American Shorthair","Bengal","Maine Coon","Persian","Scottish Fold","Siamese" };
        List<decimal> maxWeight = new List<decimal>
        { 6.8m,6.8m,8.1m,5.5m,5.9m,5.9m };
        List<decimal> minWeight = new List<decimal>
        { 5.0m,4.5m,5.9m,3.2m,4.0m,3.6m };

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal _weight, _max, _min;
            _weight = decimal.Parse(textBox1.Text);
            _max = maxWeight[comboBox1.SelectedIndex];
            _min = minWeight[comboBox1.SelectedIndex];
            string display = WeightCalculation(_weight, _max, _min);
            label3.Text = "Result\n" + display;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (string cB in catBreed)
                comboBox1.Items.Add(cB);
            label3.TextAlign = ContentAlignment.TopLeft;
        }

        Delegate3Decimal WeightCalculation = (x, maximumWeight, minimumWeight) =>
        {
            int result;

            result = Decimal.Compare(x, maximumWeight);
            if (result <= 0)
            {
                result = Decimal.Compare(x, minimumWeight);
                if (result >= 0)
                    return "Healthy Cat";
                else
                    return "Underweight... Eat more please...";
            }
            else
                return "Oppsss... It's Overweight";
        };
    }
}
