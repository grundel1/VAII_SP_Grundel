using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Models;

namespace Bakalárska__práca.Shared.Services
{
    public class ClientReviewService : IReviewService
    {
        private readonly HttpClient _httpClient;

        public ClientReviewService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Review> AddReview(Review review)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/review", review);
            return await result.Content.ReadFromJsonAsync<Review>();
        }

        public async Task<List<Review>> GetReviewsByDentistId(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Review>>($"/api/review/dentist/{id}");
            return result;
        }

        public async Task<bool> DeleteReview(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/review/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }
    }
}
