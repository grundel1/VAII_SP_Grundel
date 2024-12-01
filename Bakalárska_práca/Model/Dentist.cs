namespace Bakalárska_práca.Model
{
    public class Dentist
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
