using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeycobsGamingAdventures.Controllers
{
    public class AdventureLogController : Controller
    {
        private readonly IAdventureLogRepository _AdventureLog;
        private readonly IEnemyRepository _Enemies;

        public AdventureLogController(
            IAdventureLogRepository adventureLog,
            IEnemyRepository enemies
            )
        {
            _AdventureLog = adventureLog;
            _Enemies = enemies;
        }

        
        public async Task<IActionResult> Index(int GameId)
        {
            var logs = await _AdventureLog.GetAllLogByGameIdAsync(GameId);
            ViewBag.Enemies = await _Enemies.GetAllEnemiesByGameIdAsync(GameId);

            var topDeaths = logs.Where(x => x.Type == "Death")  // Only consider "Death" logs
           .GroupBy(l => l.EnemyId)  // Group by EnemyId
           .Select(g => new
           {
               EnemyId = g.Key,
               Enemy = logs.FirstOrDefault(l => l.EnemyId == g.Key)?.Enemy, // Get the first instance to retrieve Enemy details
               DeathCount = g.Count()  // Count total deaths per EnemyId
           })
           .OrderByDescending(x => x.DeathCount)  // Order by highest death count
           .Take(3)  // Get the top 3
           .ToList();

            ViewBag.TopDeaths = topDeaths;



            ViewBag.TopDeaths = topDeaths;

            return View(logs.Reverse());
        }
    }

}