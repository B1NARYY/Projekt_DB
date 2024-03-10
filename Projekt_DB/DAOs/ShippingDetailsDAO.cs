using Projekt_DB.Tables;
using System.Data.SqlClient;
namespace Projekt_DB.DAOs
{
    public class ShippingDetailsDAO
    {

        public void UpdateShippingDetails(ShippingDetails shippingDetails)
        {

            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "UPDATE ShippingDetails SET shipping_address = @shippingAddress, shipping_method = @shippingMethod, delivery_status = @deliveryStatus WHERE shipping_id = @shippingId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@order_id", shippingDetails.OrderId);
                cmd.Parameters.AddWithValue("@shipping_address", shippingDetails.ShippingAddress);
                cmd.Parameters.AddWithValue("@shipping_method", shippingDetails.ShippingMethod);
                cmd.Parameters.AddWithValue("@delivery_status", shippingDetails.DeliveryStatus);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
