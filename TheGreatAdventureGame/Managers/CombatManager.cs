using System;
using System.Diagnostics.Eventing.Reader;
using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

namespace TheGreatAdventureGame.Managers
{
    public class CombatManager
    {
        public static void EntityDealsWeaponEffect(ICombatant targetCombatant, IWeapon? weapon = null)
        {
            IEntity combatEntity = (IEntity)targetCombatant;
            if(weapon == null)
            {
                if (combatEntity.EquiptItem == null) 
                {
                    Console.WriteLine($"{combatEntity.Name} doesn't have an item equipted.");
                    return;
                }

                if(combatEntity.EquiptItem is IWeapon equiptWeapon)
                {
                    // Default weapon to equipted weapon
                    weapon = equiptWeapon;
                }
                else
                {
                    Console.WriteLine($"Canoot attack with {combatEntity.EquiptItem}, not a weapon.");
                    return;
                }
            }

            EntityTakesEffectFromWeapon(targetCombatant, weapon);
        }

        public static void EntityTakesEffectFromWeapon(ICombatant combatant, IWeapon weapon)
        {
            IEntity combatEntity = (IEntity)combatant;
            IItem weaponItem = (IItem)weapon;

            ApplyVitalEffectFromItem(combatEntity, weaponItem);
        }

        public static void EntityTakesEffectFromConsumable(IConsumer consumer, IConsumable? consumable = null)
        {
            IEntity consumerEntity = (IEntity)consumer;
            if (consumable == null)
            {
                if(consumerEntity.EquiptItem == null)
                {
                    Console.WriteLine($"{consumerEntity.Name} doesn't have an item equipted.");
                    return;
                }

                if(consumerEntity.EquiptItem is IConsumable equiptConsumable)
                {
                    // Default consumable to equipted consumable
                    consumable = equiptConsumable;
                }
                else
                {
                    Console.WriteLine($"Canoot consume {consumerEntity.EquiptItem}, not a consumable.");
                    return;
                }
            }
            
            IItem consumableItem = (IItem)consumable;

            ApplyVitalEffectFromItem(consumerEntity, consumableItem);
        }

        public static void EntityHealsSelf(ISelfHealing selfHealingEntity)
        {
            IEntity entity = (IEntity)selfHealingEntity;
            int amount = selfHealingEntity.HealEffectRange.GetRandomValueFromBaseRange();
            entity.Health.Add(amount);
        }

        //
        public static void ApplyVitalEffectFromItem(IEntity entity, IItem item, int? amount = null)
        {
            if(item is IWeapon weapon)
            {
                if (amount == null)
                {
                    // Default to weapon effect if no amount is provided
                    amount = weapon.AttackEffectRange.GetRandomValueFromRarityRange(item.Rarity);
                }

                if (entity is ICombatant)
                {
                    ApplyVitalEffect(amount.Value, weapon.TargetVital, weapon.EffectType, entity);
                }
                else
                {
                    throw new ArgumentException($"{entity.Name} cannot consume {item.Name}: not a consumer.");
                }
            }
            else if(item is IConsumable consumable)
            {

                if (amount == null)
                {
                    // Default to consumable effect if no amount is provided
                    amount = consumable.NutritionValueRange.GetRandomValueFromRarityRange(item.Rarity);
                }

                if (entity is IConsumer)
                {
                    ApplyVitalEffect(amount.Value, consumable.TargetVital, consumable.EffectType, entity);
                }
                else
                {
                    throw new ArgumentException($"{entity.Name} cannot consume {item.Name}: not a consumer.");
                }
                
            }
            else
            {
                throw new ArgumentException($"Error in {nameof(ApplyVitalEffectFromItem)}: pass in item must be weapon or consumable.");
            }
        }

        private static void ApplyVitalEffect(int amount, VitalType targetVital, EffectType effectType, IEntity entity)
        {
            if (targetVital == VitalType.Health)
            {
                EffectVital(amount, entity.Health, effectType);
            }
            else if (entity is ISurvivalVitals entitySurvivalVitals)
            {
                switch (targetVital)
                {
                    case VitalType.Hunger:
                        EffectVital(amount, entitySurvivalVitals.Hunger, effectType);
                        break;
                    case VitalType.Thirst:
                        EffectVital(amount, entitySurvivalVitals.Thirst, effectType);
                        break;
                    case VitalType.Random:
                        VitalType randomVitalType = ItemHelper.GetRandomEnumValue<VitalType>();

                        if (randomVitalType == VitalType.Hunger)
                        {
                            EffectVital(amount, entitySurvivalVitals.Hunger, effectType);
                        }
                        else if (randomVitalType == VitalType.Thirst)
                        {
                            EffectVital(amount, entitySurvivalVitals.Thirst, effectType);
                        }
                        else
                        {
                            EffectVital(amount, entity.Health, effectType);
                        }

                        break;
                    default:
                        throw new ArgumentException($"Invalid target vital: {targetVital}");
                }
            }
            else
            {
                throw new ArgumentException($"{entity.Name} does not have the {targetVital} vital.");
            }
        }

        private static void EffectVital(int amount, Vital entityTargetVital, EffectType vitalEffectType)
        {
            switch(vitalEffectType)
            {
                case EffectType.Positive:
                    entityTargetVital.Add(amount);
                    break;
                case EffectType.Negative:
                    entityTargetVital.Subtract(amount);
                    break;
                case EffectType.Random:
                    EffectType randomEffectType = ItemHelper.GetRandomEnumValue<EffectType>();
                    
                    if(randomEffectType == EffectType.Positive)
                    {
                        entityTargetVital.Add(amount);
                    }
                    else
                    {
                        entityTargetVital.Subtract(amount);
                    }

                    break;
                default:
                    throw new ArgumentException($"Invalid vital effect type: {vitalEffectType}");
            }
        }
    }
}
