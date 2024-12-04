using Bakalárska__práca.Shared.Data;
using Bakalárska__práca.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Shared.Services
{
    public class OrderService : IOrderService
    {
        private readonly ClinicContext _context;

        public OrderService(ClinicContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            await Task.Delay(1000);

            var orders = await _context.Orders.ToListAsync();
            return orders;
        }

        public async Task<Order> AddOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<Order> EditOrder(int id, Order order)
        {
            var dbOrder = await _context.Orders.FindAsync(id);
            if (dbOrder != null)
            {
                dbOrder.Name = order.Name;
                await _context.SaveChangesAsync();
                return dbOrder;
            }

            throw new Exception("Order not found!");
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var dbOrder = await _context.Orders.FindAsync(id);
            if (dbOrder != null)
            {
                _context.Remove(dbOrder);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
