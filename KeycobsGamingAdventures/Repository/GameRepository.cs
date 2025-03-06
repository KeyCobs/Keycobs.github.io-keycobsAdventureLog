using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Repository
{
    public class GameRepository : IGameRepository
    {
        protected readonly MyDbContext _context;
        public GameRepository(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Games>> GetAllGamesAsync()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Games> GetGameById(int id)
        {
            return await _context.Games.Where(x => x.GameId == id).FirstOrDefaultAsync();
        }
    }
}
