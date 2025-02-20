using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Players
{
    public abstract class PlayerEntityBase : EntityBase, ICombatant, IConsumer, IInventory
    {
        public Dictionary<string, string> Inventory => throw new NotImplementedException();

        public void Consume(string consumableInstanceId) => CombatManager.EntityTakesEffectFromConsumable(this, consumableInstanceId);
        public void DealWeaponEffect(IEntity targetEntity) => CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        public void TakeWeaponEffect(string weaponInstanceId) => CombatManager.EntityTakesEffectFromWeapon(this, weaponInstanceId);
        public void DropItem(string itemInstanceId) => InventoryManager.EntityDropsItem(this, itemInstanceId);
        public void EquiptItem(string itemInstanceId) => InventoryManager.EntityEquiptsItem(this, itemInstanceId);
        public void PickUpItem(string itemInstanceId) => InventoryManager.EntityPicksUpItem(this, itemInstanceId);
    }
}
