using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakalárska__práca.Shared.Model
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Políčko názvu nesmie byť prázdne.")]
        public required string Name { get; set; }

        public DateTime OrderTime { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime Time { get; set; }
        public string Specialization { get; set; }
        public int DentistId { get; set; }
        [ForeignKey("DentistId")]
        public Dentist Dentist { get; set; } = null!;

        //public int UserId { get; set; }
        //public User User { get; set; } = null!;
        //public ICollection<OrderInfo> OrderInfo { get; set; } = null!;

        public Order()
        {
            
            OrderTime = DateTime.Today;
            OrderPlaced = DateTime.Now;
        }
    }
}
