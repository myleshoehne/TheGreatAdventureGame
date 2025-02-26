using Microsoft.AspNetCore.Mvc;
using TheGreatAdventureGame.State;

namespace TheGreatAdventureGame.Controllers
{
    public class PlayerCreationController : Controller
    {
        private readonly GameState _gameState;
        public PlayerCreationController(GameState gameState)
        {
            this._gameState = gameState;
        }

        [HttpGet]
        [Route("PlayerCreation/CreatePlayer")]
        public IActionResult CreatePlayer()
        {
            return View(_gameState);
        }
    }
}
