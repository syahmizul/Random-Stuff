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
    public partial class OrderTable : Form
    {
        public OrderTable()
        {
            InitializeComponent();
        }

        private void OrderTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookiesDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.cookiesDataSet.Order);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.cookiesDataSet);
        }
    }
}
