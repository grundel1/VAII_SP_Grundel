using Bakalárska__práca.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace Bakalárska__práca.Shared.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
