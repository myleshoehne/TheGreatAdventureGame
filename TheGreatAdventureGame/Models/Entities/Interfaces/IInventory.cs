using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IInventory
    {
        Dictionary<string, string> Inventory { get; }
        void PickUpItem(string itemInstanceId);
        void EquiptItem(string itemInstanceId);
        void DropItem(string itemInstanceId);
    }
}
