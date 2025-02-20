using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Consumables.Food
{
    public class Apple : ConsumableBase, IStackable
    {
        public override int ItemID => 3;
        public override string Name { get; } = "Apple";
        public override string Description { get; } = "Apple description here...";
        public Vital Quantity { get; set; } = new Vital(1);
        public override NumberRange NutritionValueRange { get; set; } = new NumberRange(5, 10);

        public Apple() { }
        public Apple(Rarity rarity) : base(rarity)
        {
        }
    }
}
