using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bakalárska__práca.Shared.Models;

namespace Bakalárska__práca.Shared.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime Time { get; set; }
        public string Specialization { get; set; }
        public int DentistId { get; set; }
        [ForeignKey("DentistId")]
        public Dentist Dentist { get; set; } = null!;
        public string? UserId { get; set; }
        [ForeignKey("UserId")] 
        public ApplicationUser? User { get; set; } = null!;

        public Order()
        {
            
            OrderTime = DateTime.Today;
            OrderPlaced = DateTime.Now;
        }
    }
}
