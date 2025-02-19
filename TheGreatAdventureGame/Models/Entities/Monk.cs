using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

namespace TheGreatAdventureGame.Models.Entities
{
    public class Monk : IEntity, IConsumer, IWeaponTarget, IWeaponOperator
    {
        public string Name { get; set; } = "Monk";
        public string Description { get; set; } = "Monk Description here";
        public Vital Health { get; set; } = new Vital(100);
        public IItem? EquiptedItem { get; set; } = new Sword(); //give staff 


        public void Consume()
        {
            if(this.EquiptedItem == null)
            {
                Console.WriteLine($"{this.Name} doesn't have an item equipted.");
                return;
            }

            if(this.EquiptedItem is not IConsumable consumable)
            {
                Console.WriteLine($"{this.EquiptedItem} cannot be consumed: is not a consumable item.");
                return;
            }

            CombatManager.EntityTakesEffectFromConsumable(this, consumable);
        }

        public void TakeWeaponEffect(IWeapon weapon)
        {
            CombatManager.EntityTakesEffectFromWeapon(this, weapon);
        }

        public void DealWeaponEffect(IEntity targetEntity)
        {
            CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        }
    }
}
