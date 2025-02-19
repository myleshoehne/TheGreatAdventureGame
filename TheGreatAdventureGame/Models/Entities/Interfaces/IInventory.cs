using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IInventory
    {
        //TODO: make this have an instanceID
        Dictionary<string, IItem> Items { get; set; }
        void PickUpItem(IItem item);
        void EquiptItem(string itemName);
        void DropItem(string itemName);
    }
}
