using Microsoft.EntityFrameworkCore;

namespace Rapid_Rescue.Model
{
    public class Rapid_RescueDbContext : DbContext
    {
        Rapid_RescueDbContext() { }
        public Rapid_RescueDbContext(DbContextOptions<Rapid_RescueDbContext> options) : base(options)
        {

        }
        public DbSet<ambulance> ambulances { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Emt> Emts { get; set; }

    }
}
