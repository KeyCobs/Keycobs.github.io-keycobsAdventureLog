using System.ComponentModel.DataAnnotations;

namespace KeycobsGamingAdventures.Models.Entity
{
    public class Locations : LocationsDetail
    {
        public Games? Game { get; set; }
        public IEnumerable<Enemies>? Enemies { get; set; }
        public IEnumerable<AdventureLog>? adventureLogs { get; set; }
    }

    public class LocationsDetail
    {
        [Key]
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public string SubType { get; set; }
        [Required]
        public int GameId { get; set; }
    }
}
