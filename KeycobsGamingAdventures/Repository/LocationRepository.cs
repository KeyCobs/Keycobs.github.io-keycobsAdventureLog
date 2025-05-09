using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Repository
{
    public class LocationRepository : ILocationRepository
    {
        protected readonly MyDbContext _context;
        public LocationRepository(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<IEnumerable<Locations>> GetAllLocationsByGameIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Locations>> GetAllLocationsBySubTypeAsync(string subType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Locations>> GetAllLocationsByTypeAsync(string type)
        {
            return await _context.Locations.Where(x => x.Type == type).ToListAsync();
        }

        public Task<IEnumerable<Locations>> GetAllTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Locations> GetLocationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
