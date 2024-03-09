using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.Tables
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }

        public override string ToString()
        {
            return $"OrderItemId: {OrderItemId}, OrderId: {OrderId}, ProductId: {ProductId}, Quantity: {Quantity}, TotalPrice: {TotalPrice}";
        }
    }
}
