namespace Bakalárska_práca.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string InsuranceComp { get; set; } = null!;
    }
}
