﻿using System;
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
        private readonly ApplicationDbContext _context;
        public DentistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Dentist>> GetAllDentists()
        {
            var dentists = await _context.Dentists.ToListAsync();
            return dentists;
        }

        public async Task<Dentist> GetDentistById(int id)
        {
            return await _context.Dentists.FindAsync(id);
        }

        public async Task<List<Dentist>> GetFilteredDentists(string? specialization, string? region)
        {
            var filtered = _context.Dentists.AsQueryable();
            if (specialization != "Všetky")
            {
                filtered = filtered.Where(d => d.Specialization == specialization);
            }
            if (region != "Všetko")
            {
                filtered = filtered.Where(d => d.Region == region);
            }
            return await filtered.ToListAsync();
        }

        public async Task UpdateDentist(Dentist dentist)
        {
            var dentistEntity = await _context.Dentists.FindAsync(dentist.Id);
            if (dentistEntity != null)
            {
                dentistEntity.PhotoUrl = dentist.PhotoUrl;
                await _context.SaveChangesAsync();
            }
        }

    }
}
