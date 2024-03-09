using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.Tables
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool Availability { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductId}, Name: {Name}, Price: {Price}, Availability: {Availability}";
        }
    }
}
