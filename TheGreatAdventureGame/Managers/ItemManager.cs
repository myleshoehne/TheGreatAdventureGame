using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Items;

namespace TheGreatAdventureGame.Managers
{
    public class ItemManager
    {
        public static void DealDamage(IEntity? entity, IItem item)
        {
            if (entity != null)
            {
                if (entity is IDamagable damagableEntity)
                {
                    if (item is IDealsDamage dealDamageItem)
                        damagableEntity.TakeDamage(dealDamageItem.HealthEffectRange.GetRandomValueFromRarityRange(item.Rarity));
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
