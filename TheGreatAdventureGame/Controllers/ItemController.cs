using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TheGreatAdventureGame.FakeDatabase;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.State;
using TheGreatAdventureGame.ViewModels;

namespace TheGreatAdventureGame.Controllers
{
    public class ItemController : Controller
    {
        private readonly GameState _gameState;
        public ItemController(GameState gameState)
        {
            this._gameState = gameState;
        }

        [HttpGet]
        public IActionResult ItemStats(string itemInstanceId)
        {
            //TODO: get instance id from item and return that item in the view
            IItem? item = ItemsDB.GetItemById(itemInstanceId);


            ItemStatsViewModel viewModel = new ItemStatsViewModel
            {
                InstanceID = item.InstanceID,
                Name = item.Name,
                Description = item.Description,
                Rarity = item.Rarity,
                ImageUrl = item.ImageUrl
            };

            decimal multiplier = Helpers.ItemHelper.GetRarityMultiplier(item.Rarity);

            if (item is IWeapon weapon)
            {
                int minWithRarity = (int)Math.Round(weapon.AttackEffectRange.Min * multiplier);
                int maxWithRarity = (int)Math.Round(weapon.AttackEffectRange.Max * multiplier);

                viewModel.AttackEffectRange = $"{minWithRarity} - {maxWithRarity}";
                viewModel.EffectType = weapon.EffectType.ToString();
                viewModel.TargetVital = weapon.TargetVital.ToString();
            }
            else if (item is IConsumable consumable)
            {  
                int minWithRarity = (int)Math.Round(consumable.NutritionValueRange.Min * multiplier);
                int maxWithRarity = (int)Math.Round(consumable.NutritionValueRange.Max * multiplier);

                viewModel.NutritionValueRange = $"{minWithRarity} - {maxWithRarity}";
                viewModel.EffectType = consumable.EffectType.ToString();
                viewModel.TargetVital = consumable.TargetVital.ToString();
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult EquipItem(string itemInstanceId)
        {
            IItem? item = ItemsDB.GetItemById(itemInstanceId);
            this._gameState.Player.EquiptItem(item);

            return RedirectToAction("Home", "Adventure");
        }
    }
}
