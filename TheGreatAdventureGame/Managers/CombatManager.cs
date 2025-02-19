using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class CombatManager
    {
        // Entity Methods

        public static void EntityDealsWeaponEffect(IEntity entity, IEntity targetEntity)
        {
            if (targetEntity == null || entity == null)
            {
                Console.WriteLine($"Attacking entity or target entity is nothing.");
                return;
            }

            if (targetEntity is not IWeaponTarget weaponTarget)
            {
                Console.WriteLine($"Connot attack {targetEntity.Name}: not an attackable entity.");
                return;
            }

            if (entity.EquiptedItem is not IWeapon equiptedWeapon)
            {
                Console.WriteLine($"{entity.EquiptedItem} can not deal weapon effect to {targetEntity.Name}: not a weapon.");
                return;
            }

            weaponTarget.TakeWeaponEffect(equiptedWeapon);
        }

        public static void EntityTakesEffectFromWeapon(IEntity entity, IWeapon weapon)
        {
            if (weapon == null)
            {
                Console.WriteLine("Cannot take weapon effect from nothing.");
                return;
            }

            if (weapon is IConsumable)
            {
                Console.WriteLine($"Cannot take weapon effect from consumable: {weapon.Name}");
                return;
            }

            if (weapon is not IVitalEffects effectiveItem)
            {
                Console.WriteLine($"{weapon.Name} cannot be used.");
                return;
            }

            if(entity is not IWeaponTarget)
            {
                Console.WriteLine($"Cannot use {weapon.Name} on {entity.Name}: not a weapon target.");
            }

            int amount = effectiveItem.VitalEffectRange.GetRandomValueFromRarityRange(weapon.Rarity);
            //TODO: Look to wrap this into a method as we are repeating it
            if (entity is ISurvivalVitals entityWithSurvivalVitals)
            {
                if(weapon.EffectSurvivalVitalType == SurvivalVitalType.Health)
                {
                    ApplyVitalEffect(entity.Health, amount, weapon.VitalEffectType);
                }
                else if (weapon.EffectSurvivalVitalType == SurvivalVitalType.Hunger)
                {
                    ApplyVitalEffect(entityWithSurvivalVitals.Hunger, amount, weapon.VitalEffectType);
                }
                else
                {
                    ApplyVitalEffect(entityWithSurvivalVitals.Thirst, amount, weapon.VitalEffectType);
                }
            }
            else
            {
                if(weapon.EffectSurvivalVitalType != SurvivalVitalType.Health)
                {
                    Console.WriteLine($"{entity.Name} only has health, but {weapon.Name} is trying to affect {weapon.EffectSurvivalVitalType}");
                    return;
                }

                ApplyVitalEffect(entity.Health, amount, weapon.VitalEffectType);
            }
        }

        public static void EntityTakesEffectFromConsumable(IEntity entity, IConsumable consumable)
        {
            if (consumable == null)
            {
                Console.WriteLine("Cannot consume nothing.");
                return;
            }

            if (consumable is IWeapon)
            {
                Console.WriteLine($"Cannot consume a weapon: {consumable.Name}.");
                return;
            }

            if (consumable is not IVitalEffects effectiveItem)
            {
                Console.WriteLine($"{consumable.Name} cannot be consumed.");
                return;
            }

            int amount = effectiveItem.VitalEffectRange.GetRandomValueFromRarityRange(consumable.Rarity);
            //TODO: Look to wrap this into a method as we are repeating it
            if (entity is ISurvivalVitals entityWithSurvivalVitals)
            {
                if (consumable.EffectSurvivalVitalType == SurvivalVitalType.Health)
                {
                    ApplyVitalEffect(entity.Health, amount, consumable.VitalEffectType);
                }
                else if (consumable.EffectSurvivalVitalType == SurvivalVitalType.Hunger)
                {
                    ApplyVitalEffect(entityWithSurvivalVitals.Hunger, amount, consumable.VitalEffectType);
                }
                else
                {
                    ApplyVitalEffect(entityWithSurvivalVitals.Thirst, amount, consumable.VitalEffectType);
                }
            }
            else
            {
                if (consumable.EffectSurvivalVitalType != SurvivalVitalType.Health)
                {
                    Console.WriteLine($"{entity.Name} only has health, but {consumable.Name} is trying to affect {consumable.EffectSurvivalVitalType}");
                    return;
                }

                ApplyVitalEffect(entity.Health, amount, consumable.VitalEffectType);
            }
        }

        private static void ApplyVitalEffect(Vital entityVital, int amount, VitalEffectType vitalEffectType)
        {
            switch (vitalEffectType)
            {
                case VitalEffectType.Positive:
                    entityVital.Add(amount);
                    break;
                case VitalEffectType.Negative:
                    entityVital.Subtract(amount);
                    break;
                case VitalEffectType.Random:
                    VitalEffectType randomEffect = ItemHelper.GetRandomVitalEffectType();
                    if (randomEffect == VitalEffectType.Positive)
                    {
                        entityVital.Add(amount);
                    }
                    else
                    {
                        entityVital.Subtract(amount);
                    }
                    break;
                default:
                    throw new ArgumentException($"{vitalEffectType} is not a valid effect type.");
            }
        }
    } 
}
