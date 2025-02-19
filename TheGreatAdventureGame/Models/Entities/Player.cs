using System.Text.Json.Serialization;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities
{
    public class Player : IEntity, IWeaponOperator, IWeaponTarget, IConsumer, ISurvivalVitals, IInventory
    {
        public string Name { get; set; } = ""; //allow users to create this
        public string Description { get; set; } = "The entity the player is.";
        public Vital Health { get; set; } = new Vital(100);
        [JsonIgnore]
        public IItem? EquiptedItem { get; set; }
        public Vital Hunger { get; set; } = new Vital(100);
        public Vital Thirst { get; set; } = new Vital(100);
        public Dictionary<string, IItem> Items { get; set; } = new Dictionary<string, IItem>(StringComparer.OrdinalIgnoreCase);

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

        public void DropItem(string itemName)
        {
            InventoryManager.EntityDropsItem(this, itemName);
        }

        public void EquiptItem(string itemName)
        {
            InventoryManager.EntityEquiptsItem(this, itemName);
        }

        public void PickUpItem(IItem item)
        {
            InventoryManager.EntityPicksUpItem(this, item);
        }

        
    }
}
