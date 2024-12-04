namespace Bakalárska__práca.Shared.Model
{
    public class Order
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime OrderPlaced { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; } = null!;
        public ICollection<OrderInfo> OrderInfo { get; set; } = null!;
    }
}
