using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Data;
using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Shared.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Review> AddReview(Review review)
        {
            var contextValidation = new ValidationContext(review);
            Validator.ValidateObject(review, contextValidation, validateAllProperties: true);

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public async Task<List<Review>> GetReviewsByDentistId(int id)
        {
            return await _context.Reviews
                .Where(o => o.DentistId == id)
                .ToListAsync();
        }

        public async Task<bool> DeleteReview(int id)
        {
            var dbReview = await _context.Reviews.FindAsync(id);
            if (dbReview != null)
            {
                _context.Remove(dbReview);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
