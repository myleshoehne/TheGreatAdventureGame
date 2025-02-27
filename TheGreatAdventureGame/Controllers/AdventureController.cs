using Microsoft.AspNetCore.Mvc;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Weapons;
using TheGreatAdventureGame.State;
using TheGreatAdventureGame.ViewModels;

namespace TheGreatAdventureGame.Controllers
{
    public class AdventureController : Controller
    {
        private readonly GameState _gameState;
        public AdventureController(GameState gameState)
        {
            this._gameState = gameState;
        }

        [HttpGet]
        [ActionName("Start")]
        public IActionResult StartGet(PlayerCreationViewModel createdPlayer)
        {
            return View(createdPlayer);
        }

        [HttpPost]
        [ActionName("Start")]
        public IActionResult StartPost(PlayerCreationViewModel createdPlayer)
        {
            _gameState.Player = new Player(createdPlayer.Name);

            // TODO: turn to select statement and use nameof()
            if(createdPlayer.StartingWeapon.ToLower() == "sword")
            {
                Sword sword = new Sword(Rarity.Common);
                _gameState.Player.PickUpItem(sword);
                _gameState.Player.EquiptItem(sword);
            }
            else if(createdPlayer.StartingWeapon.ToLower() == "crossbow")
            {
                Crossbow crossbow = new Crossbow(Rarity.Common);
                _gameState.Player.PickUpItem(crossbow);
                _gameState.Player.EquiptItem(crossbow);
            }

            
            return RedirectToAction("Home", "Adventure");
        }

        [HttpGet]
        public IActionResult Home()
        {
            //TODO: Generate levels

            return View(_gameState);
        }
    }
}
