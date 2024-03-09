using Projekt_DB.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.DAOs
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["product_id"]);
                    product.Name = reader["name"].ToString();
                    product.Price = Convert.ToSingle(reader["price"]);
                    product.Availability = Convert.ToBoolean(reader["availability"]);

                    products.Add(product);
                }

                reader.Close();
            }

            return products;
        }
        public void AddProduct(Product product)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "INSERT INTO Products (name, price, availability) VALUES (@name, @price, @availability)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@availability", product.Availability);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Product added successfully");
        }

    }
}
