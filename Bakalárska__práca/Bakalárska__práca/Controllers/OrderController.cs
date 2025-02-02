using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Controllers
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _orderService.GetOrderById(id);
            return Ok(order);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<List<Order>>> GetOrdersByUserId(string userId)
        {
            var orders = await _orderService.GetOrdersByUserId(userId);
            return Ok(orders);
        }


        [HttpPost]
        public async Task<ActionResult<Order>> AddOrders(Order order)
        {
            var addedOrder = await _orderService.AddOrder(order);
            return Ok(addedOrder);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Order>> EditOrder(int id, Order order)
        {
            var updatedOrder = await _orderService.EditOrder(id, order);
            return Ok(updatedOrder);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var result = await _orderService.DeleteOrder(id);
            return Ok(result);
        }

    }
}
