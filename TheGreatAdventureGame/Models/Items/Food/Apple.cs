using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Food
{
    public class Apple : IConsumable, IStackable
    {
        public string Name { get; set; } = "Apple";
        public string Description { get; set; } = "Apple description here...";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public Vital Quantity { get; set; } = new Vital(1);
        public NumberRange VitalEffectRange { get; set; } = new NumberRange(5, 10);
        public VitalEffectType VitalEffectType { get; set; } = VitalEffectType.Positive;
        public SurvivalVitalType EffectSurvivalVitalType { get; set; } = SurvivalVitalType.Health;
        
        public Apple() { }
        public Apple(Rarity rarity)
        {
            this.Rarity = rarity;
        }
        public void ConsumedByEntity(IEntity entity)
        {
            CombatManager.ConsumableConsumedByEntity(this, entity);
        }
    }
}
