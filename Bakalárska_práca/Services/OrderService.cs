using Bakalárska_práca.Data;
using Bakalárska_práca.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska_práca.Services
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
            var dbGame = await _context.Orders.FindAsync(id);
            if (dbGame != null)
            {
                dbGame.Name = order.Name;
                await _context.SaveChangesAsync();
                return dbGame;
            }

            throw new Exception("Game not found!");
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var dbGame = await _context.Orders.FindAsync(id);
            if (dbGame != null)
            {
                _context.Remove(dbGame);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
