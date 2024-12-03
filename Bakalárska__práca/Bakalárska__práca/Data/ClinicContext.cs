using Bakalárska__práca.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Data
{
    public class ClinicContext : DbContext
    {
        public DbSet<Dentist> Dentists { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderInfo> OrderInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-140TCCMK\\SQLEXPRESS;Database=DentistSystemDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {

        }
    }
}
