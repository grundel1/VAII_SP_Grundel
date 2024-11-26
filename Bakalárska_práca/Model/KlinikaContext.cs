using Microsoft.EntityFrameworkCore;

namespace Bakalárska_práca.Model
{
    public class KlinikaContext : DbContext
    {
        public DbSet<Zubar> Zubari { get; set; }

        public KlinikaContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
