using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Repository.Interfaces
{
    public interface IGameRepository
    {
        Task<IEnumerable<Games>> GetAllGamesAsync();
        Task<Games> GetGameById(int id);
    }
}
