using Microsoft.AspNetCore.Mvc;
using TheGreatAdventureGame.FakeDatabase;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
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
                ItemsDB.AddItem(sword);
            }
            else if(createdPlayer.StartingWeapon.ToLower() == "crossbow")
            {
                Crossbow crossbow = new Crossbow(Rarity.Common);
                _gameState.Player.PickUpItem(crossbow);
                _gameState.Player.EquiptItem(crossbow);
                ItemsDB.AddItem(crossbow);
            }

            
            return RedirectToAction("Home", "Adventure");
        }

        [HttpGet]
        public IActionResult Home()
        {
            //TODO: Generate levels

            //testing

            Crossbow RareCrossBow = new Crossbow(Rarity.Rare);
            _gameState.Player.PickUpItem(RareCrossBow);
            ItemsDB.AddItem(RareCrossBow);

            Crossbow UncommonCrossBow = new Crossbow(Rarity.Common);
            _gameState.Player.PickUpItem(UncommonCrossBow);
            ItemsDB.AddItem(UncommonCrossBow);

            Apple LegendaryApple = new Apple(Rarity.Legendary);
            _gameState.Player.PickUpItem(LegendaryApple);
            ItemsDB.AddItem(LegendaryApple);
            

            Apple CommonApple = new Apple(Rarity.Common);
            _gameState.Player.PickUpItem(CommonApple);
            ItemsDB.AddItem(CommonApple);

            Console.WriteLine(ItemsDB.Items);
            //_gameState.Player.PickUpItem(new Apple(Rarity.Uncommon));
            //_gameState.Player.PickUpItem(new Sword(Rarity.Epic));
            //_gameState.Player.PickUpItem(new Sword(Rarity.Legendary));
            //_gameState.Player.PickUpItem(new Apple(Rarity.Legendary));

            return View(_gameState);
        }
    }
}
