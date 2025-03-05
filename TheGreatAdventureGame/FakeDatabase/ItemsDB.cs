using System.Runtime.CompilerServices;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.FakeDatabase
{
    public static class ItemsDB
    {
        public static List<IItem> Items { get; } = new();

        /// <summary>
        /// Adds a new item to the Items collection if an item with the same instance ID does not already exist.
        /// </summary>
        /// <param name="item">The item to add.</param>
        /// <returns>True if the item was added successfully, otherwise false.</returns>
        public static bool AddItem(IItem item)
        {
            if(!Items.Any(i => i.InstanceID == item.InstanceID))
            {
                Items.Add(item);
                return true;
            }

            return false;
        }


        /// <summary>
        /// Retrieves an item from the Items collection that matches the given instance ID.
        /// Returns null if no matching item is found.
        /// </summary>
        /// <param name="instanceId">The unique identifier of the item to find.</param>
        /// <returns>The matching IItem if found, otherwise null.</returns>
        public static IItem? GetItemById(string instanceId)
        {
            return Items.FirstOrDefault(i => i.InstanceID == instanceId);
        }
    }
}
