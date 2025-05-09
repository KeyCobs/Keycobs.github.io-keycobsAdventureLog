using KeycobsGamingAdventures.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Models.Mapper
{
    public class LocationConfiguration : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasOne(l => l.Game)
                   .WithMany(x => x.Locations)
                   .HasForeignKey(e => e.GameId);

            builder.HasMany(e => e.adventureLogs)
                   .WithOne(x => x.Location)
                   .HasForeignKey(x => x.LocationId);

            builder.HasMany(e => e.Enemies)
                   .WithOne(x => x.Location)
                   .HasForeignKey(x => x.LocationId);
        }
    }
}