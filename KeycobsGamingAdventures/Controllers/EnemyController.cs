using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeycobsGamingAdventures.Controllers
{
    public class EnemyController : Controller
    {
        private readonly ILocationRepository _locaitons;
        private readonly IEnemyRepository _enemies;

        public EnemyController(ILocationRepository locaitons, IEnemyRepository enemies)
        {
            _locaitons = locaitons;
            _enemies = enemies;
        }

        public async Task<IActionResult> Index(int EnemyId)
        {
            return View( await _enemies.GetEnemyViewModelByIdAsync(EnemyId));
        }
    }
}
