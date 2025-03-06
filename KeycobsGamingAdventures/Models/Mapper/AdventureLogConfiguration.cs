using KeycobsGamingAdventures.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Models.Mapper
{
    public class AdventureLogConfiguration : IEntityTypeConfiguration<AdventureLog>
    {
        public void Configure(EntityTypeBuilder<AdventureLog> builder)
        {
            builder.HasOne(e => e.Game)
                   .WithMany(x => x.adventureLogs)
                   .HasForeignKey(e => e.GameId);

            builder.HasOne(e => e.Location)
                   .WithMany(x => x.adventureLogs)
                   .HasForeignKey(e => e.LocationId);

            builder.HasOne(e => e.Enemy)
                   .WithMany(x => x.adventureLogs)
                   .HasForeignKey(e => e.EnemyId);

        }
    }
}
