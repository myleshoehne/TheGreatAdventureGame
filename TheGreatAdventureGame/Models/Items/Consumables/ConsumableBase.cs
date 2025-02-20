using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Consumables
{
    public abstract class ConsumableBase : ItemBase, IConsumable
    {
        public abstract NumberRange NutritionValueRange { get; set; }
        public virtual VitalImpactType ImpactType { get; set; } = VitalImpactType.Positive;
        public virtual VitalCategoryType TargetVital { get; set; } = VitalCategoryType.Health;

        protected ConsumableBase() { }
        protected ConsumableBase(Rarity rarity) : base(rarity) { }

        //TODO: add more contructors
    }
}
