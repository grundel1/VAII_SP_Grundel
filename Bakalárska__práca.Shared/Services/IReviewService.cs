using Bakalárska__práca.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakalárska__práca.Shared.Models;

namespace Bakalárska__práca.Shared.Services
{
    public interface IReviewService
    {
        Task<Review> AddReview(Review review);
        Task<Review> GetReviewsByDentistId(int id);
    }
}
