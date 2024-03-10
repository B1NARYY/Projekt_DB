using Projekt_DB.Tables;
using System.Data.SqlClient;

namespace Projekt_DB.DAOs
{
    public class OrderDAO
    {

        //Method to get all orders from the database
        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            SqlConnection conn = DatabaseSingleton.GetInstance();
            
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = Convert.ToInt32(reader["order_id"]);
                    order.CustomerId = Convert.ToInt32(reader["customer_id"]);
                    order.OrderDate = Convert.ToDateTime(reader["order_date"]);
                    order.OrderStatus = reader["order_status"].ToString();
                    orders.Add(order);
                }

                reader.Close();
            

            return orders;
        }

        //Method to get all orders from the database by customer id
        public static List<Order> GetOrdersByCustomerId(int customerId)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "SELECT * FROM Orders WHERE customer_id = @customerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = Convert.ToInt32(reader["order_id"]);
                    order.CustomerId = Convert.ToInt32(reader["customer_id"]);
                    order.OrderDate = Convert.ToDateTime(reader["order_date"]);
                    order.OrderStatus = reader["order_status"].ToString();
                    orders.Add(order);
                }

                reader.Close();
            }

            return orders;
        }
        //Method to add an order to the database
        public void AddOrder(Order order)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "INSERT INTO Orders (customer_id, order_date, order_status) VALUES (@customerId, @orderDate, @orderStatus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@orderStatus", order.OrderStatus);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Order added successfully");
        }
    }

}
