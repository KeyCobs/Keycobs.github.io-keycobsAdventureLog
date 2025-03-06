using System.Diagnostics;
using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Models.NewFolder;
using KeycobsGamingAdventures.Repository;
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
            return View(logs.Reverse());
        }
    }

}