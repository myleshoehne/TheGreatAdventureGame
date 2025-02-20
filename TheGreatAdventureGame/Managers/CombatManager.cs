using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class CombatManager
    {
        public static void EntityDealsWeaponEffect(IEntity entity, IEntity targetEntity)
        {
            //TODO: implement deal weapon logic
            Console.WriteLine($"{entity.Name} consumed item with id: {targetEntity.Name}.");
        }

        public static void EntityTakesEffectFromWeapon(IEntity entity, string weaponInstanceId)
        {
            //TODO: implement affect from weapon logic
            Console.WriteLine($"{entity.Name} took weapon affect from item with id: {weaponInstanceId}.");
        }

        public static void EntityTakesEffectFromConsumable(IEntity affectedEntity, string consumableInstanceId)
        {
            //TODO: implement consume affect logic
            Console.WriteLine($"{affectedEntity.Name} consumed item with id: {consumableInstanceId}.");
        }

        public static void EntityHealsSelf(IEntity entity)
        {
            //TODO: implement heal self logic
            Console.WriteLine($"{entity.Name} haled self.");
        }

        private static void ApplyVitalEffect(Vital entityVital, int amount, VitalImpactType vitalImpactType)
        {
            switch (vitalImpactType)
            {
                case VitalImpactType.Positive:
                    entityVital.Add(amount);
                    break;
                case VitalImpactType.Negative:
                    entityVital.Subtract(amount);
                    break;
                case VitalImpactType.Random:
                    VitalImpactType randomEffect = ItemHelper.GetRandomVitalImpactType();
                    if (randomEffect == VitalImpactType.Positive)
                    {
                        entityVital.Add(amount);
                    }
                    else
                    {
                        entityVital.Subtract(amount);
                    }
                    break;
                default:
                    throw new ArgumentException($"{vitalImpactType} is not a valid effect type.");
            }
        }
    }
}
