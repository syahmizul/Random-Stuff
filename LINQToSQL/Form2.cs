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
    public partial class Form2 : Form
    {
        CookiesCustomer cookiesCustomer = new CookiesCustomer();

        private void ClearForm()
        {
            textBoxName.Text = string.Empty;
            labelCustomerID.Text = "Customer ID";
            textBoxCompany.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            labelOrderID.Text = "Order ID";
            textBoxQuantity.Text = string.Empty;
        }

        private void InitialState()
        {
            buttonSearch.Enabled = true;
            buttonReset.Enabled = false;
            buttonNew.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            textBoxName.Enabled = true;
            textBoxCompany.Enabled = false;
            textBoxPhone.Enabled = false;
            textBoxQuantity.Enabled = false;
            dateTimePickerOrder.Enabled = false;
        }

        private void EnableNewUpdateDelete()
        {
            buttonReset.Enabled = true;
            buttonNew.Enabled = true;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            textBoxName.Enabled = true;
            textBoxCompany.Enabled = true;
            textBoxPhone.Enabled = true;
            textBoxQuantity.Enabled = false;
            dateTimePickerOrder.Enabled = false;
            labelOrderID.Text = "Order ID";
            textBoxQuantity.Text = string.Empty;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitialState();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            cookiesCustomer.CustName = textBoxName.Text;
            cookiesCustomer.SearchCustomer();

            if (cookiesCustomer.FlagCustomer)
            {
                textBoxName.Text = cookiesCustomer.CustName;
                labelCustomerID.Text = cookiesCustomer.CustID;
                textBoxCompany.Text = cookiesCustomer.CustCompany;
                textBoxPhone.Text = cookiesCustomer.CustPhone;

                EnableNewUpdateDelete();
            }
            else
            {
                MessageBox.Show("Customer does not exist.Please fill in the form.");
                labelCustomerID.Text = cookiesCustomer.CustID;
                textBoxCompany.Enabled = true;
                textBoxPhone.Enabled = true;
                buttonNew.Enabled = true;
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            cookiesCustomer.GenerateOrderID();

            labelOrderID.Text = cookiesCustomer.OrderID.ToString();

            textBoxQuantity.Enabled = true;
            dateTimePickerOrder.Enabled = true;
            textBoxName.Enabled = false;
            textBoxCompany.Enabled = false;
            textBoxPhone.Enabled = false;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSearch.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cookiesCustomer.CustName = textBoxName.Text;
            cookiesCustomer.CustID = labelCustomerID.Text;
            cookiesCustomer.CustCompany = textBoxCompany.Text;
            cookiesCustomer.CustPhone = textBoxPhone.Text;
            cookiesCustomer.OrderID = int.Parse(labelOrderID.Text);
            cookiesCustomer.Quantity = int.Parse(textBoxQuantity.Text);
            cookiesCustomer.OrderDate = dateTimePickerOrder.Value;

            cookiesCustomer.SaveCustomerOrder();
            MessageBox.Show("Order has been saved.");
            EnableNewUpdateDelete();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cookiesCustomer.CustName = textBoxName.Text;
            cookiesCustomer.CustID = labelCustomerID.Text;
            cookiesCustomer.CustCompany = textBoxCompany.Text;
            cookiesCustomer.CustPhone = textBoxPhone.Text;

            cookiesCustomer.UpdateCustomer();
            MessageBox.Show("Customer details has been updated.");
            EnableNewUpdateDelete();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you confirm to delete this data?";
            string title = "Delete Customer and Order Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.Yes)
            {
                cookiesCustomer.CustID = labelCustomerID.Text;
                cookiesCustomer.DeleteCustomerOrder();
                MessageBox.Show("Customer and orders has been deleted.");
                ClearForm();
                InitialState();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearForm();
            InitialState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookiesCustomer.CalculateQuantity();
        }
    }
}
