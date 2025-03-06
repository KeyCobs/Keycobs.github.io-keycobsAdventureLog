using System.Diagnostics;
using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeycobsGamingAdventures.Controllers
{
    public class GameController : Controller
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameRepository _game;

        public GameController(
            ILogger<GameController> logger,
            IGameRepository game)
        {
            _logger = logger;
            _game = game;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _game.GetAllGamesAsync());
        }
    }
}
