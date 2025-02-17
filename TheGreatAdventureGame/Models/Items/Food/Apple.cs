using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items.Food
{
    public class Apple : IItem, IConsumable, IStackable
    {
        public string Name { get; set; } = "Apple";
        public string Description { get; set; } = "Apple description here...";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public Vital? Quantity { get; set; } //TODO: figure out quantity functionality (remove nullable)
        public NumberRange HealthEffectRange { get; set; } = new NumberRange(5, 10);
        public HealthEffectType HealthEffectType { get; set; } = HealthEffectType.Positive;

        public Apple() { }
        public Apple(Rarity rarity)
        {
            this.Rarity = rarity;
        }
        public void Consume(IEntity? entity)
        {
            if(entity != null)
            {
                if (entity is IDamagable damagableEntity)
                {
                    // Heal Entity
                    int healthEffect = this.HealthEffectRange.GetRandomValueFromRarityRange(this.Rarity);
                    damagableEntity.Health.Add(healthEffect);
                }
                else
                {
                    Console.WriteLine($"Cannot heal {entity.Name}. Is not of type IDamagable.");
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} cannot be consumed by nothing.");
            }
            
        }
    }
}
