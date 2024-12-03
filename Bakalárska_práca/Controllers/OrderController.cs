using Bakalárska_práca.Model;
using Bakalárska_práca.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bakalárska_práca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> AddOrders(Order order)
        {
            var addedOrder = await _orderService.AddOrder(order);
            return Ok(addedOrder);
        }
         
    }
}
