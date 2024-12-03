namespace Bakalárska__práca.Model
{
    public enum Region
    {
        BB, BL, KE, NR, PE, TN, TT, ZA   
    }


    public class Dentist
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public Region? Region { get; set; }
        public string City { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
