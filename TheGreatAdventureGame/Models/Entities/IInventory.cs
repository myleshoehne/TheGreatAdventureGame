using TheGreatAdventureGame.Models.Items;

namespace TheGreatAdventureGame.Models.Entities
{
    public interface IInventory
    {
        IItem EquiptedItem { get; set; }
        Dictionary<int, IItem> Items { get; set; }
        void EquiptItem(IItem item);
        void PickUpItem(IItem item);
        void DropItem(IItem item);
    }
}
