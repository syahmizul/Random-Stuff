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

    public partial class Form4 : Form
    {
        Func<decimal, decimal, decimal> CalculateTotal = (value1, value2) => value1 + value2;

        Action<string> DisplayMessage = str => MessageBox.Show(str);

        Predicate<decimal> Tax = totalValue => totalValue > 200;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal _medication, _consultation, totalCharge, taxCharge = 10;
            _medication = decimal.Parse(textBox1.Text);
            _consultation = decimal.Parse(textBox2.Text);
            totalCharge = CalculateTotal(_medication, _consultation);
            pricelabel1.Text = "RM " + totalCharge.ToString();

            if(Tax(totalCharge))
            {
                totalCharge = CalculateTotal(totalCharge, taxCharge);
                DisplayMessage("Tax RM10.00 will be charged. ");
            }
            pricelabel2.Text = "RM " + totalCharge.ToString();
        }
    }
}
