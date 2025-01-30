using Bakalárska__práca.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska__práca.Shared.Data
{
    public class ClinicContext : DbContext
    {
        public DbSet<Dentist> Dentists { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderInfo> OrderInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-140TCCMK\\SQLEXPRESS;Database=DentistSystemDB;Trusted_Connection=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("Bakalárska__práca"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Dentist)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.DentistId)
                .OnDelete(DeleteBehavior.Restrict);
        }


        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {

        }
    }
}
