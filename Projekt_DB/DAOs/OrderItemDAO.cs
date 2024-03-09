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

    }
}
