using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Models.Mapper;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<AdventureLog> AdventureLog { get; set; }
        public DbSet<Enemies> Enemies { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Games> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GamesConfiguration());
            modelBuilder.ApplyConfiguration(new EnemiesConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new AdventureLogConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
