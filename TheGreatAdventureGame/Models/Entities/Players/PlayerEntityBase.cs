using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Players
{
    public abstract class PlayerEntityBase : EntityBase, ICombatant, IConsumer, IInventory, ISurvivalVitals
    {
        public Dictionary<string, string> Inventory => new();
        public virtual Vital Hunger { get; set; }
        public virtual Vital Thirst { get; set; }

        public void Consume(IConsumable consumable) => CombatManager.EntityTakesEffectFromConsumable(this, consumable);
        public void DealWeaponEffect(IEntity targetEntity) => CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        public void TakeWeaponEffect(string weaponInstanceId) => CombatManager.EntityTakesEffectFromWeapon(this, weaponInstanceId);
        public void DropItem(string itemInstanceId) => InventoryManager.EntityDropsItem(this, itemInstanceId);
        public void EquiptItem(string itemInstanceId) => InventoryManager.EntityEquiptsItem(this, itemInstanceId);
        public void PickUpItem(string itemInstanceId) => InventoryManager.EntityPicksUpItem(this, itemInstanceId);

        protected PlayerEntityBase()
        {
            this.Hunger = new Vital(100);
            this.Thirst = new Vital(100);
        }
        protected PlayerEntityBase(int maxHealth, int maxHunger, int maxThirst) : base(maxHealth)
        {
            this.Hunger = new Vital(maxHunger);
            this.Thirst = new Vital(maxThirst);
        }
    }
}
