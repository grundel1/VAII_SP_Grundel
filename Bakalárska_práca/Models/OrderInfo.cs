namespace Bakalárska_práca.Model
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int DentistId { get; set; }
        public Dentist Dentist { get; set; } = null!;
    }
}
