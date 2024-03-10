using Projekt_DB.DAOs;
using Projekt_DB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB
{
    internal class ImportFromCSV
    {
        // Importing Customers from CSV files
        public void ImportCustomers()
        {
            string path = "yourPath";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                CustomerDAO customerDAO = new CustomerDAO();
                Customer customer = new Customer();
                customer.Name = columns[1];
                customer.Email = columns[2];
                customer.PhoneNumber = columns[3];
                customer.Address = columns[4];

                customerDAO.AddCustomer(customer);
            }
        }
        // Importing Orders from CSV files
        public void ImportOrders()
        {
            string path = "yourPath";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                OrderDAO orderDAO = new OrderDAO();
                Order order = new Order();
                order.CustomerId = Convert.ToInt32(columns[1]);
                order.OrderDate = Convert.ToDateTime(columns[2]);
                order.OrderStatus = columns[3];
                orderDAO.AddOrder(order);
            }
        }
        // Importing Products from CSV files
        public void ImportProducts()
        {
            string path = "yourPath";
            string[] lines = System.IO.File.ReadAllLines(path); foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                ProductDAO productDAO = new ProductDAO();
                Product product = new Product();
                product.Name = columns[1];
                product.Price = Convert.ToSingle(columns[2]);
                product.Availability = Convert.ToBoolean(columns[3]);
                productDAO.AddProduct(product);

            }
        }
        // Importing OrderItems from CSV files
        public void ImportOrderItems()
        {
            string path = "yourPath";
            string[] lines = System.IO.File.ReadAllLines(path); foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                OrderItemDAO orderItemDAO = new OrderItemDAO();
                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = Convert.ToInt32(columns[1]);
                orderItem.ProductId = Convert.ToInt32(columns[2]);
                orderItem.Quantity = Convert.ToInt32(columns[3]);
                orderItem.TotalPrice = Convert.ToSingle(columns[4]);
                orderItemDAO.AddOrderItem(orderItem);

            }
        }
    }
}
