using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : IItem, IDealsDamage, IBreakable
    {
        public string Name { get; set; } = "Sword";
        public string Description { get; set; } = "Sword description here...";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public NumberRange HealthEffectRange { get; set; } = new NumberRange(10, 15);
        public HealthEffectType HealthEffectType { get; set; } = HealthEffectType.Negative;
        public Vital Durability { get; set; } = new Vital(100);

        public void DealDamage(IEntity? entity)
        {
            if (entity != null)
            {
                if (entity is IDamagable damagableEntity)
                {
                        damagableEntity.TakeDamage(this.HealthEffectRange.GetRandomValueFromRarityRange(this.Rarity));
                }
                else
                {
                    Console.WriteLine("Entity cannot be attacked.");
                }
            }
            else
            {
                Console.WriteLine("No entity to attack.");
            }
        }
    }
}
