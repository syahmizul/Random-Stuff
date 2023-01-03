using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerTable custtable = new CustomerTable();
            custtable.MdiParent = this;
            custtable.Show();
            custtable.StartPosition = FormStartPosition.CenterScreen;

            OrderTable ordertable = new OrderTable();
            ordertable.MdiParent = this;
            ordertable.Show();
            ordertable.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
