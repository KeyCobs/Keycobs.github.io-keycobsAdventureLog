using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Models.ViewModel
{
    public class EnemyView : Enemies
    {
        public int DeathCounter { get; set; }
        public bool IsKilled { get; set; }  
    }
}
