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

        public static void EntityTakesEffectFromConsumable(IConsumer consumer, IConsumable consumable)
        {
            IEntity entity = (IEntity)consumer;
            IItem item = (IItem)consumable;

            int amount = consumable.NutritionValueRange.GetRandomValueFromRarityRange(item.Rarity);

            //TODO: Call private method
        }

        public static void EntityHealsSelf(ISelfHealing entity)
        {
            //TODO: implement heal self logic
            Console.WriteLine($"Entity haled self.");
        }


        private static void ApplyImpact()
        {
            //TODO: this method (rename maybe)
        }
        private static void ApplyImpactType()
        {
            //TODO: this method (rename maybe)
        }
    }
}
