using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Model;

namespace Bakalárska__práca.Shared.Services
{
    public class ClientOrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public ClientOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> AddOrder(Order order)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/order", order);
            return await result.Content.ReadFromJsonAsync<Order>();
        }

        public async Task<Order> GetOrderById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Order>($"/api/order/{id}");
            return result;
        }

        public async Task<List<Order>> GetOrdersByUserId(string userId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Order>>($"/api/order/user/{userId}");
            return result;
        }

        public async Task<Order> EditOrder(int id, Order order)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/order/{id}", order);
            return await result.Content.ReadFromJsonAsync<Order>();
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/order/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }
    }
}
