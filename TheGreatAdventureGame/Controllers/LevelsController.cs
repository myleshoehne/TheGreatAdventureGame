using Microsoft.AspNetCore.Mvc;
using TheGreatAdventureGame.Models.Levels;
using TheGreatAdventureGame.State;

namespace TheGreatAdventureGame.Controllers
{
    public class LevelsController : Controller
    {
        private readonly GameState _gameState;
        public LevelsController(GameState gameState)
        {
            this._gameState = gameState;
        }

        [HttpGet]
        public IActionResult HuntingLevel()
        {
            HuntingLevel level = new HuntingLevel(new Models.Entities.Players.Player("Cosmic"));
            return View(level);
        }
    }
}
