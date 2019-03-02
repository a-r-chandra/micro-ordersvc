using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class Order
    {
        public string id { get; set; }
        public ProductInfo[] products { get; set; }
        public string customer_id { get; set; }
        public double total { get; set; }
    }
}
