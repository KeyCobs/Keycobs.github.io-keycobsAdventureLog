using KeycobsGamingAdventures.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeycobsGamingAdventures.Models.Mapper
{
    public class GamesConfiguration : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder.HasMany(a => a.adventureLogs)
                   .WithOne(x => x.Game)
                   .HasForeignKey(x => x.LogId);

            builder.HasMany(a => a.Enemies)
                   .WithOne(x => x.Game)
                   .HasForeignKey(x => x.EnemyId);

            builder.HasMany(a => a.Locations)
                   .WithOne(x => x.Game)
                   .HasForeignKey(x => x.LocationId);
        }
    }
}
