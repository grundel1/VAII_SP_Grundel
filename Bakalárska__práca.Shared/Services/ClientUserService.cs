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
    public class ClientUserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public ClientUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<List<ApplicationUser>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<ApplicationUser>($"/api/user/{id}");
            return result;
        }
    }
}
