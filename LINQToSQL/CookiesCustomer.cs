using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQL
{
    class CookiesCustomer
    {
        CookiesDataContext db = new CookiesDataContext();

        public string CustID { set; get; }
        public int OrderID { set; get; }
        public string CustName { set; get; }
        public string CustCompany { set; get; }
        public string CustPhone { set; get; }
        public int Quantity { set; get; }
        public DateTime OrderDate { set; get; }
        public bool FlagCustomer { set; get; }

        public void SearchCustomer()
        {
            IEnumerable<Customer> querySearch =
                from customer in db.Customers
                where customer.ContactName == CustName
                select customer;

            if (querySearch.Count() != 0)
            {
                FlagCustomer = true;

                foreach (Customer c in querySearch)
                {
                    CustName = c.ContactName.ToString();
                    CustID = c.CustomerID.ToString();
                    CustCompany = c.CompanyName.ToString();
                    CustPhone = c.Phone.ToString();
                }
            }
            else
            {
                FlagCustomer = false;
                int checkID = 1;
                do
                {
                    GenerateCustomerID();

                    checkID = (from IDQ in db.Customers
                               where IDQ.CustomerID == CustID
                               select IDQ).Count();
                } while (checkID != 0);
            }
        }

        public void GenerateCustomerID()
        {
            Random random = new Random();
            int newID = random.Next(10000, 99999);
            CustID = newID.ToString();
        }

        public void GenerateOrderID()
        {
            int rowOrderCount =
                (from order in db.Orders
                 select order.OrderID).Max();

            OrderID = ++rowOrderCount;
        }

        public void SaveCustomerOrder()
        {
            if (!FlagCustomer)
            {
                Customer customer = new Customer();
                customer.CustomerID = CustID;
                customer.CompanyName = CustCompany;
                customer.ContactName = CustName;
                customer.Phone = CustPhone;

                db.Customers.InsertOnSubmit(customer);
            }
            Order order = new Order();
            order.OrderID = OrderID;
            order.CustomerID = CustID;
            order.OrderDate = OrderDate;
            order.OrderQuantity = Quantity;

            db.Orders.InsertOnSubmit(order);

            db.SubmitChanges();
        }

        public void CalculateQuantity()
        {
            int totalQuantity = 0;
            var queryOrder =
                from order in db.Orders
                where order.CustomerID == CustID
                select order.OrderQuantity;


            foreach (int i in queryOrder)
                totalQuantity += i;

            MessageBox.Show(totalQuantity.ToString());

        }

        public void UpdateCustomer()
        {
            IEnumerable<Customer> queryCustomer =
                from customer in db.Customers
                where customer.CustomerID == CustID
                select customer;

            foreach(Customer cDetails in queryCustomer)
            {
                cDetails.ContactName = CustName;
                cDetails.CompanyName = CustCompany;
                cDetails.Phone = CustPhone;
            }

            db.SubmitChanges();

        }

        public void DeleteCustomerOrder()
        {
            IEnumerable<Order> queryOrder =
                from order in db.Orders
                where order.CustomerID == CustID
                select order;
            IEnumerable<Customer> queryCustomer =
                from customer in db.Customers
                where customer.CustomerID == CustID
                select customer;

            foreach (Order oDetails in queryOrder)
                db.Orders.DeleteOnSubmit(oDetails);

            foreach (Customer cDetails in queryCustomer)
                db.Customers.DeleteOnSubmit(cDetails);

            db.SubmitChanges();
        }

    }
}
