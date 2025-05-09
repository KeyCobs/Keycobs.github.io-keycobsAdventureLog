using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Models.ViewModel;

namespace KeycobsGamingAdventures.Repository.Interfaces
{
    public interface IEnemyRepository
    {
        Task<IEnumerable<Enemies>> GetAllEnemiesAsync();
        Task<Enemies> GetEnemyWithMostDeathByGameIdAsync(int id);
        Task<Enemies> GetEnemyById(int id);
        Task<IEnumerable<Enemies>> GetAllEnemiesByGameIdAsync(int id);
        Task<EnemyView> GetEnemyViewModelByIdAsync(int id);

        Task<IEnumerable<Enemies>> GetEnemiesByRegionAsync(string type);
        Task<IEnumerable<Enemies>> GetEnemiesByLocationIdAsync(int locationId);
    }
}
