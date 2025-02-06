using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Model;

namespace Bakalárska__práca.Shared.Services
{
    public class ClientDentistService : IDentistService
    {
        private readonly HttpClient _httpClient;

        public ClientDentistService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<List<Dentist>> GetAllDentists()
        {
            throw new NotImplementedException();
        }

        public async Task<Dentist> GetDentistById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Dentist>($"/api/dentist/{id}");
            return result;
        }

        public async Task<List<Dentist>> GetFilteredDentists(string? specialization, string? region)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Dentist>>($"/api/dentist/{specialization}");
            return result;
        }

        public Task UpdateDentist(Dentist dentist)
        {
            throw new NotImplementedException();
        }
    }
}
