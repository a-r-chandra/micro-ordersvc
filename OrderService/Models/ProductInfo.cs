using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class ProductInfo
    {
        public string product_id { get; set; }
        public string product_title { get; set; }
        public double product_price { get; set; }
        public int product_quantity { get; set; }

    }
}
