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
        public IItem? EquiptedItem { get; set; } = new Sword(); //TODO: give staff 

        public void Consume(IConsumable consumable)
        {
            CombatManager.EntityTakesEffectFromConsumable(this, consumable);
        }

        public void DealWeaponEffect(IEntity targetEntity)
        {
            CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        }
        public void TakeWeaponEffect(IWeapon weapon)
        {
            CombatManager.EntityTakesEffectFromWeapon(this, weapon);
        }
    }
}
