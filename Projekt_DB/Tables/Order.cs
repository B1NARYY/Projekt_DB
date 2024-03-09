using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.Tables
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, CustomerId: {CustomerId}, OrderDate: {OrderDate}, OrderStatus: {OrderStatus}";
        }
    }
}
