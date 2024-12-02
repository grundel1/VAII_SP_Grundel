using Microsoft.EntityFrameworkCore;

namespace Bakalárska_práca.Model
{
    public class ClinicContext : DbContext
    {
        public DbSet<Dentist> Dentists { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderInfo> OrderInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DentistSystem");
        }

        
        public ClinicContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
