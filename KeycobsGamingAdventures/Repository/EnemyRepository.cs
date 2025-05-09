using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Models.ViewModel;
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

        public Task<IEnumerable<Enemies>> GetEnemiesByLocationIdAsync(int locationId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Enemies>> GetEnemiesByRegionAsync(string type)
        {
            var e = _context.Enemies.Include(x => x.Location).AsQueryable(); // No need for `await` here
            var a = await e.Where(x => x.Location != null && x.Location.Type == type)
                          .ToListAsync();
            return a;
        }



        public Task<Enemies> GetEnemyById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EnemyView> GetEnemyViewModelByIdAsync(int id)
        {
            var enemy = await _context.Enemies
                .Where(x => x.EnemyId == id)
                .Select(e => new EnemyView
                {
                    EnemyId = e.EnemyId,
                    Name = e.Name,
                    LocationId = e.LocationId,
                    IsBoss = e.IsBoss,
                    DamageType = e.DamageType,
                    GameId = e.GameId,
                    EnemyImage = e.EnemyImage,
                    Game = e.Game,
                    Location = e.Location,
                    adventureLogs = e.adventureLogs.Where(x => x.EnemyId == id).ToList(),
                })
                .FirstOrDefaultAsync();

            // Fetch IsKilled and DeathCounter separately to avoid async inside LINQ
            enemy.IsKilled = await _context.AdventureLog
                .AnyAsync(x => x.EnemyId == id && x.Type == "Killed");

            enemy.DeathCounter = await _context.AdventureLog
                .CountAsync(x => x.EnemyId == id && x.Type == "Death");

            return enemy;
        }



        public Task<Enemies> GetEnemyWithMostDeathByGameIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
