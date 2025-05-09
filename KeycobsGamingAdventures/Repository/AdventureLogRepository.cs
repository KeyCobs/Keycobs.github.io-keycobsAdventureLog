using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Repository
{
    public class AdventureLogRepository : IAdventureLogRepository
    {
        protected readonly MyDbContext _context;
        public AdventureLogRepository(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<AdventureLog>> GetAllLogAsync()
        {
            return await _context.AdventureLog.Include(x => x.Enemy).ToListAsync();
        }

        public async Task<IEnumerable<AdventureLog>> GetAllLogByGameIdAsync(int id)
        {
            return await _context.AdventureLog.Where(x => x.GameId == id)
                                              .OrderBy(x => x.LogId)
                                              .Include(x => x.Enemy)
                                              .Include(x => x.Location)
                                              .ToListAsync();
        }

        public async Task<IEnumerable<AdventureLog>> GetAllLogByRegionAsync(string type)
        {
            return await _context.AdventureLog.Where(x => x.Location.Type == type).ToListAsync();
        }

        public Task<AdventureLog> GetLogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
