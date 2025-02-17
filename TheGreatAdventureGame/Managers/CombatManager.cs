using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class CombatManager
    {
        public static void DealDamageToEntity(IEntity? entity, IItem? item)
        {
            if (entity == null)
            {
                Console.WriteLine("No entity to attack.");
                return;
            }

            if (item == null)
            {
                Console.WriteLine($"{entity.Name} was attacked by nothing.");
                return;
            }

            if (entity is not IDamagable damagableEntity)
            {
                Console.WriteLine($"{entity.Name} cannot be attacked.");
                return;
            }

            if (item is not IWeapon weapon)
            {
                Console.WriteLine($"Cannot attack with {item.Name}");
                return;
            }

            damagableEntity.DamageSurvialVital(weapon);

            if(item is IBreakable breakableItem)
            {
                breakableItem.Durability.Subtract(1);
            }
        }
    }
}
