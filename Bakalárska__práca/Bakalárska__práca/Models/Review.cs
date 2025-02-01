using System.ComponentModel.DataAnnotations.Schema;

namespace Bakalárska__práca.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int DentistId { get; set; }
        [ForeignKey("DentistId")]
        public Dentist Dentist { get; set; } = null!;
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
