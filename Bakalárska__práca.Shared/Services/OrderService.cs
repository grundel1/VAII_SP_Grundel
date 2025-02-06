using System.ComponentModel.DataAnnotations;
using Bakalárska__práca.Shared.Data;
using Bakalárska__práca.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Shared.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
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
            var contextValidation = new ValidationContext(order);
            Validator.ValidateObject(order, contextValidation, validateAllProperties: true);

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<List<Order>> GetOrdersByUserId(string userId)
        {
            return await _context.Orders
                .Where(o => o.UserId == userId)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByDentistAndDate(int dentistId, DateTime date)
        {
            return await _context.Orders
                .Where(o => o.DentistId == dentistId && o.OrderTime.Date == date.Date)
                .ToListAsync();
        }

        public async Task<Order> EditOrder(int id, Order order)
        {
            var dbOrder = await _context.Orders.FindAsync(id);
            if (dbOrder != null)
            {
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
