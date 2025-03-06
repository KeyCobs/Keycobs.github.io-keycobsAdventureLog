using System.ComponentModel.DataAnnotations;

namespace KeycobsGamingAdventures.Models.Entity
{
    public class AdventureLog : AdventureLogDetail
    {
        public Games ?Game { get; set; }
        public Enemies ?Enemy { get; set; }
        public Locations ?Location {  get; set; }    

    }

    public class AdventureLogDetail
    {
        [Key]
        [Required]
        public int LogId { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Event { get; set; }
        [Required]
        public int? GameId { get; set; } 
        public int? EnemyId { get; set; }
        [Required]
        public int? LocationId { get; set; }

    }
}
