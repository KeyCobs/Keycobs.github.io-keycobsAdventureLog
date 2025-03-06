using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Models.NewFolder
{
    public class AdventureLogView : AdventureLog
    {
        IEnumerable<Enemies> SingleEnemiesList { get; set; }
    }
}
