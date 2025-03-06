using System.ComponentModel.DataAnnotations;

namespace KeycobsGamingAdventures.Models.Entity
{
    public class Enemies : EnemiesDetail
    {
        public Games ?Game { get; set; }
        public Locations ?Location { get; set; }

        public IEnumerable<AdventureLog> ?adventureLogs { get; set; }
    }

    public class EnemiesDetail
    {
        [Key]
        [Required]
        public int EnemyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public bool IsBoss { get; set; }
        [Required]
        public string DamageType { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public string EnemyImage { get; set; }
    }
}
