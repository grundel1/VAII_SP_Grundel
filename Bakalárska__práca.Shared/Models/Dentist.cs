using Bakalárska__práca.Shared.Models;

namespace Bakalárska__práca.Shared.Model
{
    public class Dentist
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Region { get; set; }
        public string City { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string Specialization { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
