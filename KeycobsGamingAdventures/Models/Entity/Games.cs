using System.ComponentModel.DataAnnotations;

namespace KeycobsGamingAdventures.Models.Entity
{
    public class Games : GamesDetail
    {
        public IEnumerable<Locations> ?Locations { get; set; }
        public IEnumerable<AdventureLog> ?adventureLogs { get; set; }
        public IEnumerable<Enemies> ?Enemies { get; set; }
    }

    public class GamesDetail
    {
        [Key]
        [Required]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CoverImage { get; set; }
        [Required]
        public string TitleImage { get; set; }
        [Required]
        public string CharacterImage { get; set; }
    }
}
