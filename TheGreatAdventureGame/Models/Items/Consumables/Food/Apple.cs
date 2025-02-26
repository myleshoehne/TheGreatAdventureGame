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
        public Vital Quantity { get; set; }
        public override NumberRange NutritionValueRange { get; set; } = new NumberRange(5, 10); 

        public Apple()
        {
            Initialize();
        }
        public Apple(Rarity rarity) : base(rarity)
        {
            Initialize();
        }

        private void Initialize()
        {
            // Apples spawn in groups of 1-3
            Random random = new Random();
            int appleQuantity = random.Next(1, 4);
            this.Quantity = new Vital(appleQuantity, 10);
        }
    }
}
