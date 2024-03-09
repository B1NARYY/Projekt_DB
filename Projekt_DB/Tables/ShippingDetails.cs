using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.Tables
{
    public class ShippingDetails
    {
        public int ShippingId { get; set; }
        public int OrderId { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingMethod { get; set; }
        public string DeliveryStatus { get; set; }

        public override string ToString()
        {
            return $"ShippingId: {ShippingId}, OrderId: {OrderId}, ShippingAddress: {ShippingAddress}, ShippingMethod: {ShippingMethod}, DeliveryStatus: {DeliveryStatus}";
        }

    }
}
