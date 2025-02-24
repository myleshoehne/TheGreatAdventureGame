using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Consumables
{
    public abstract class ConsumableBase : ItemBase, IConsumable
    {
        public abstract NumberRange NutritionValueRange { get; set; }
        public virtual EffectType EffectType { get; set; } = EffectType.Positive;
        public virtual VitalType TargetVital { get; set; } = VitalType.Health;

        protected ConsumableBase() { }
        protected ConsumableBase(Rarity rarity) : base(rarity) { }

        //TODO: add more contructors
    }
}
