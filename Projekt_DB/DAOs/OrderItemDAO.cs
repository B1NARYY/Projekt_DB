using Projekt_DB.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.DAOs
{
    public class OrderItemDAO
    {
        //Method to get all order items
        public static List<OrderItem> GetItemsInOrder(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();

            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "SELECT * FROM Order_Items WHERE order_id = @orderId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderItem item = new OrderItem();
                    item.OrderItemId = Convert.ToInt32(reader["order_item_id"]);
                    item.OrderId = Convert.ToInt32(reader["order_id"]);
                    item.ProductId = Convert.ToInt32(reader["product_id"]);
                    item.Quantity = Convert.ToInt32(reader["quantity"]);
                    item.TotalPrice = Convert.ToSingle(reader["total_price"]);
                    items.Add(item);
                }

                reader.Close();
            }

            return items;
        }
        //Method to add an order item
        public void AddOrderItem(OrderItem item)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "INSERT INTO Order_Items (order_id, product_id, quantity, total_price) VALUES (@orderId, @productId, @quantity, @totalPrice)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", item.OrderId);
                cmd.Parameters.AddWithValue("@productId", item.ProductId);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@totalPrice", item.TotalPrice);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Order item added successfully");
        }
        //Method to remove an order item
        public void RemoveOrderItem(int orderItemId)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "DELETE FROM Order_Items WHERE order_item_id = @orderItemId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderItemId", orderItemId);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Order item removed successfully");
        }

    }
}
