using KeycobsGamingAdventures.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeycobsGamingAdventures.Models.Mapper
{
    public class EnemiesConfiguration : IEntityTypeConfiguration<Enemies>
    {
        public void Configure(EntityTypeBuilder<Enemies> builder)
        {
            builder.HasOne(e => e.Game)
                   .WithMany(x => x.Enemies)
                   .HasForeignKey(e => e.GameId);

            builder.HasOne(e => e.Location)
                   .WithMany(x => x.Enemies)
                   .HasForeignKey(e => e.LocationId);

            builder.HasMany(e => e.adventureLogs)
                   .WithOne(x => x.Enemy)
                   .HasForeignKey(x => x.LogId);
        }
    }
}
