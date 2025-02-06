using Bakalárska__práca.Shared.Model;
using Bakalárska__práca.Shared.Models;
using Bakalárska__práca.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bakalárska__práca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Review>> AddReview(Review review)
        {
            var addedReview = await _reviewService.AddReview(review);
            return Ok(addedReview);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Review>>> GetReviewsByDentistId(int id)
        {
            var reviews = await _reviewService.GetReviewsByDentistId(id);
            return Ok(reviews);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteReview(int id)
        { 
            var result = await _reviewService.DeleteReview(id);
            return Ok(result);
        }
    }
}

