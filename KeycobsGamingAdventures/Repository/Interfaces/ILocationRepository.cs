using KeycobsGamingAdventures.Models.Entity;

namespace KeycobsGamingAdventures.Repository.Interfaces
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Locations>> GetAllLocationsByGameIdAsync(int id);
        Task<Locations> GetLocationByIdAsync(int id);
        Task<IEnumerable<Locations>> GetAllLocationsByTypeAsync(string type);
        Task<IEnumerable<Locations>> GetAllTypeAsync();
        Task<IEnumerable<Locations>> GetAllLocationsBySubTypeAsync(string subType);

    }
}
