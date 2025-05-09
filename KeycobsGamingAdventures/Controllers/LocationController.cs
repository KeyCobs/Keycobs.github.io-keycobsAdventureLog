using KeycobsGamingAdventures.Models.Entity;
using KeycobsGamingAdventures.Models.ViewModel;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeycobsGamingAdventures.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository _location;
        private readonly IAdventureLogRepository _AdventureLog;
        private readonly IEnemyRepository _enemy;

        public LocationController(
            ILocationRepository location,
            IAdventureLogRepository adventureLog,
            IEnemyRepository enemy
            )
        {
            _location = location;
            _AdventureLog = adventureLog;
            _enemy = enemy;
        }

        public async Task<IActionResult> Region(string type)
        {

            // Get all enemies in this region
            var enemies = await _enemy.GetEnemiesByRegionAsync(type);

            var logs = await _AdventureLog.GetAllLogByRegionAsync(type);

            // Get all locations within this region
            var locations = await _location.GetAllLocationsByTypeAsync(type);

            // Calculate death counts per enemy
            var deathCounts = logs
                .Where(log => log.EnemyId.HasValue)
                .GroupBy(log => log.EnemyId.Value)
                .ToDictionary(g => g.Key, g => g.Count());

            // Create the view model
            var viewModel = new RegionView
            {
                Region = type,
                Enemies = enemies,
                Logs = logs,
                Locations = locations,
                DeathCounts = deathCounts
            };

            return View(viewModel);
           
        }
    }
}
