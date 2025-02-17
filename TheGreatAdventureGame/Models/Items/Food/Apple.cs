using TheGreatAdventureGame.Helpers;
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
        public NumberRange EffectRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public HealthEffectType EffectType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SurvivalVitalType EffectSurvivalVitalType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Apple() { }
        public Apple(Rarity rarity)
        {
            this.Rarity = rarity;
        }
        public void ConsumeBy(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
