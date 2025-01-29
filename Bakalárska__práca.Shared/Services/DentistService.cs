using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Data;
using Bakalárska__práca.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Shared.Services
{
    public class DentistService : IDentistService
    {
        private readonly ClinicContext _context;
        public DentistService(ClinicContext context)
        {
            _context = context;
        }

        public async Task<List<Dentist>> GetAllDentists()
        {
            var dentists = await _context.Dentists.ToListAsync();
            return dentists;
        }

        public async Task<List<Dentist>> GetFilteredDentists(string? specialization, string? region)
        {
            var query = _context.Dentists.AsQueryable();

            if (!string.IsNullOrWhiteSpace(specialization))
                query = query.Where(d => d.Specialization == specialization);

            if (!string.IsNullOrWhiteSpace(region))
                query = query.Where(d => d.Region == region);

            return await query.ToListAsync();
        }
    }
}
