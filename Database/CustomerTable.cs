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
    public partial class CustomerTable : Form
    {
        public CustomerTable()
        {
            InitializeComponent();
        }

        private void CustomerTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookiesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cookiesDataSet.Customer);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.cookiesDataSet);
        }
    }
}
