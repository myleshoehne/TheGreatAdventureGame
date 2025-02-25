using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Consumables.Food
{
    public class Apple : ConsumableBase, IStackable
    {
        public override string Name { get; } = "Apple";
        public override string Description { get; } = "Apple description here...";
        public Vital Quantity { get; set; } = new Vital(1, 10); //TODO: add functionallity to make this spawn with a random quantity
        public override NumberRange NutritionValueRange { get; set; } = new NumberRange(5, 10); 

        public Apple() { }
        public Apple(Rarity rarity) : base(rarity)
        {
        }
    }
}
