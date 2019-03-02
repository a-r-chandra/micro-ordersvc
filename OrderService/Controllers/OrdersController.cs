using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/Orders
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new Order[] {
                new Order{
                    id = Guid.NewGuid().ToString(),
                    customer_id = "rchandra-4a4f-d6a11bea",
                    products = new ProductInfo[]{
                        new ProductInfo{
                            product_id = "978-1788479356",
                            product_title = "Learning Continuous Integration with Jenkins",
                            product_price = 44.99,
                            product_quantity = 10
                        }
                    },
                    total = 449.90
                }
            };
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
