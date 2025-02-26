using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Players
{
    public abstract class PlayerEntityBase : EntityBase, ICombatant, IConsumer, IInventory, ISurvivalVitals
    {
        public Dictionary<string, IItem> Inventory { get; set; } = new();
        public virtual Vital Hunger { get; set; }
        public virtual Vital Thirst { get; set; }

        //TODO: allow these to reach out to new InventoryManager methods
        public void Consume(IConsumable? consumable = null) => CombatManager.EntityTakesEffectFromConsumable(this, consumable);
        public void DealWeaponEffect(ICombatant targetEntity) => CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        public void TakeWeaponEffect(IWeapon usedWeapon) => CombatManager.EntityTakesEffectFromWeapon(this, usedWeapon);
        public void DropItem(IItem? item) => InventoryManager.EntityDropsItem(this, item);
        public void EquiptItem(IItem item) => InventoryManager.EntityEquiptsItem(this, item);
        public void PickUpItem(IItem item) => InventoryManager.EntityPicksUpItem(this, item);

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
