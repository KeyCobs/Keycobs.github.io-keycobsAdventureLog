using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Models.ViewModel
{
    public class RegionView
    {
        public string? Region { get; set; } // The specific location (region)
        public IEnumerable<Enemies> Enemies { get; set; } // Enemies in this region

        public IEnumerable<AdventureLog> Logs { get; set; } // Adventure logs in this region
        public IEnumerable<Locations> Locations { get; set; } // Other locations in this region
        public Dictionary<int, int> DeathCounts { get; set; } // EnemyId -> Death Count

        public RegionView()
        {
            DeathCounts = new Dictionary<int, int>();
        }
    }

}
