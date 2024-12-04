using Bakalárska__práca.Shared.Model;

namespace Bakalárska__práca.Shared.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> AddOrder(Order order);
        Task<Order> GetOrderById(int id);
        Task<Order> EditOrder(int id, Order order);
        Task<bool> DeleteOrder(int id);
    }
}
