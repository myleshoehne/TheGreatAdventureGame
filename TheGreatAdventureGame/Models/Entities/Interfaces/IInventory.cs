using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IInventory
    {
        Dictionary<int, IItem> Items { get; set; }
        void EquiptItem(IItem item);
        void PickUpItem(IItem item);
        void DropItem(IItem item);
    }
}
