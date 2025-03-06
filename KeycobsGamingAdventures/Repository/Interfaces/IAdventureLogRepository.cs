using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Repository.Interfaces
{
    public interface IAdventureLogRepository
    {
        Task<IEnumerable<AdventureLog>> GetAllLogAsync();
        Task<IEnumerable<AdventureLog>> GetAllLogByGameIdAsync(int id);
        Task<AdventureLog> GetLogByIdAsync(int id);
    }
}
