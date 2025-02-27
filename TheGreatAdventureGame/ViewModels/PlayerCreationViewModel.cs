using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

namespace TheGreatAdventureGame.ViewModels
{
    public class PlayerCreationViewModel
    {
        public string? Name { get; set; }

        public string? StartingWeapon { get; set; }

        public List<string> StartingWeaponOptions { get; } = new List<string>()
        {
            "Sword",
            "Crossbow"
        };
    }
}
