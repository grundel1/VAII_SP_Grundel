using Bakalárska__práca.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalárska__práca.Shared.Services
{
    public interface IDentistService
    {
        Task<List<Dentist>> GetAllDentists();
        Task<Dentist> GetDentistById(int id);
        Task<List<Dentist>> GetFilteredDentists(string? specialization, string? region);
    }
}
