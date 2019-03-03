using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using static Utilities.NetworkUtils;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private IHttpContextAccessor _httpContextAccessor;
        public OrdersController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Orders
        [HttpGet]
        public Tuple<IEnumerable<Order>, string> Get()
        {
            return new Tuple<IEnumerable<Order>, string>(new Order[] {
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
            }, $"Called from: {GetRequestInfo(_httpContextAccessor)} " +
            $" | Handled by machine: {Environment.MachineName}, IP: [{GetIPs()}], OS: {Environment.OSVersion}");
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


    }
}
