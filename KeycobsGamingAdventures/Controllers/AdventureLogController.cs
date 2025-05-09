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

            var topDeaths = logs
                        .Where(x => x.Type == "Death" && x.Enemy != null)
                        .GroupBy(l => l.EnemyId)
                        .Select(g =>
                        {
                            var firstLog = g.FirstOrDefault(); // Get first log entry for this enemy
                            return new
                            {
                                Enemy = firstLog?.Enemy,
                                DeathCount = g.Count()
                            };
                        })
                        .OrderByDescending(x => x.DeathCount)
                        .ToList();

            var topLocationDeaths = logs.Where(x => x.Type == "Death" && x.Enemy != null)
                                        .GroupBy(l => l.LocationId)
                                        .Select(g =>
                                        {
                                            var firsLog = g.FirstOrDefault();
                                            return new
                                            {
                                                Location = firsLog.Location,
                                                DeathCount = g.Count()
                                            };
                                        })
                                        .OrderByDescending(x => x.DeathCount)
                                        .ToList();
            ViewBag.TopDeaths = topDeaths;
            ViewBag.TopLocationDeaths = topLocationDeaths;

            return View(logs.Reverse());

        }
    }

}