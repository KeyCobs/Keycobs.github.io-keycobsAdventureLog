using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KeycobsGamingAdventures.Repository
{
    public class EnemyRepository : IEnemyRepository
    {

        protected readonly MyDbContext _context;
        public EnemyRepository(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<IEnumerable<Enemies>> GetAllEnemiesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Enemies>> GetAllEnemiesByGameIdAsync(int id)
        {
            return await _context.Enemies.Where(x => x.GameId == id).ToListAsync();
        }

        public Task<Enemies> GetEnemyById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Enemies> GetEnemyWithMostDeathByGameIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
