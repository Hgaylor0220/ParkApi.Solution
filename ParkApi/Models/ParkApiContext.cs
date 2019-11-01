using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
    public class ParkApiDbContext : DbContext
    {
        public ParkApiDbContext(DbContextOptions<ParkApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
    }
}