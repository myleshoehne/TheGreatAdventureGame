using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IInventory
    {
        Dictionary<string, IItem> Inventory { get; }
        void PickUpItem(IItem item);
        void EquiptItem(IItem item);
        void DropItem(IItem? item);
    }
}
