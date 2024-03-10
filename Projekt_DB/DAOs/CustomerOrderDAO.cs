using Projekt_DB.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.DAOs
{
    public class CustomerOrderDAO
    {
        public void CreateOrderAndCustomer(Customer customer, Order order)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "INSERT INTO Customers (name, email, phone_number, address) VALUES (@name, @email, @phoneNumber, @address)";
                query += "INSERT INTO Orders (customer_id, order_date, total_price, order_status) VALUES (SCOPE_IDENTITY(), @orderDate, @totalPrice, @orderStatus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@customerId", customer.CustomerId);

                cmd.Parameters.AddWithValue("@customerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@orderStatus", order.OrderStatus);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
