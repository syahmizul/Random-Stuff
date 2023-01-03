using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQL
{
    public partial class Form1 : Form
    {

        CookiesDataContext db = new CookiesDataContext();

        public Form1()
        {
            InitializeComponent();
        }


        private void viewTableCustomer(IEnumerable<Customer> queryCustomer)
        {
            DataTable dtTableCustomer = new DataTable();

            dtTableCustomer.Columns.Add("Customer ID", typeof(string));
            dtTableCustomer.Columns.Add("Name", typeof(string));
            dtTableCustomer.Columns.Add("Company", typeof(string));
            dtTableCustomer.Columns.Add("Phone", typeof(string));

            foreach(Customer customer in queryCustomer)
            {
                DataRow dtRowCustomer = dtTableCustomer.NewRow();

                dtRowCustomer["Customer ID"] = customer.CustomerID.ToString();
                dtRowCustomer["Name"] = customer.ContactName.ToString();
                dtRowCustomer["Company"] = customer.CompanyName.ToString();
                dtRowCustomer["Phone"] = customer.Phone.ToString();

                dtTableCustomer.Rows.Add(dtRowCustomer);
            }

            dataGridView1.DataSource = dtTableCustomer;

            comboBox1.Items.Clear();

            foreach(DataColumn comboData in dtTableCustomer.Columns)
            {
                string dataCol = comboData.ToString();

                if (Equals(dataCol, "Customer ID") | Equals(dataCol, "Name"))
                    comboBox1.Items.Add(comboData.ToString());
            }
        }

        public void viewTableOrder(IEnumerable<Order> queryOrder)
        {
            DataTable dtTableOrder = new DataTable();

            dtTableOrder.Columns.Add("Order ID", typeof(string));
            dtTableOrder.Columns.Add("Customer ID", typeof(string));
            dtTableOrder.Columns.Add("Order Date", typeof(string));
            dtTableOrder.Columns.Add("Quantity", typeof(string));

            foreach (Order order in queryOrder)
            {
                DataRow dtRowOrder = dtTableOrder.NewRow();

                dtRowOrder["Order ID"] = order.OrderID.ToString();
                dtRowOrder["Customer ID"] = order.CustomerID.ToString();
                dtRowOrder["Order Date"] = order.OrderDate.ToString();
                dtRowOrder["Quantity"] = order.OrderQuantity.ToString();

                dtTableOrder.Rows.Add(dtRowOrder);
            }

            dataGridView2.DataSource = dtTableOrder;
        }

        private void displayAllData()
        {
            IEnumerable<Customer> queryCustomer =
                from customer in db.Customers
                select customer;

            viewTableCustomer(queryCustomer);

            IEnumerable<Order> queryOrder =
                from order in db.Orders
                select order;

            viewTableOrder(queryOrder);
            radioButtonQty.Checked = false;
            radioButtonID.Checked = false;
            buttonFind.Enabled = false;
            textBoxMinQty.Text = string.Empty;
            textBoxCustID.Text = string.Empty;
            labelMinQty.Enabled = false;
            labelCustID.Enabled = false;
            textBoxCustID.Enabled = false;
            textBoxMinQty.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayAllData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Customer> querySortCust;

            if(comboBox1.SelectedIndex == 0)
            {
                querySortCust = from customer in db.Customers
                                orderby customer.CustomerID
                                select customer;
            }
            else
            {
                querySortCust = from customer in db.Customers
                                orderby customer.ContactName
                                select customer;
            }

            viewTableCustomer(querySortCust);
        }

        private void radioButtonQty_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMinQty.Text = string.Empty;
            textBoxCustID.Text = string.Empty;
            buttonFind.Enabled = true;

            if(radioButtonQty.Checked)
            {
                labelMinQty.Enabled = true;
                labelCustID.Enabled = false;
                textBoxMinQty.Enabled = true;
                textBoxCustID.Enabled = false;
            }
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMinQty.Text = string.Empty;
            textBoxCustID.Text = string.Empty;
            buttonFind.Enabled = true;
            if(radioButtonID.Checked)
            {
                labelMinQty.Enabled = false;
                labelCustID.Enabled = true;
                textBoxMinQty.Enabled = false;
                textBoxCustID.Enabled = true;
            }

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            IEnumerable<Order> queryFind;
            if(radioButtonQty.Checked)
            {
                queryFind = from order in db.Orders
                            where order.OrderQuantity >= int.Parse(textBoxMinQty.Text)
                            select order;
            }
            else
            {
                queryFind = from order in db.Orders
                            where order.CustomerID == textBoxCustID.Text
                            select order;

            }
            viewTableOrder(queryFind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayAllData();
        }
    }
}
