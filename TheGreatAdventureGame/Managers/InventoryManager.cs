using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class InventoryManager
    {
        public static void EntityEquiptsItem(IEntity entity, string itemName)
        {
            if (entity is not IInventory entityInventory)
            {
                Console.WriteLine($"{entity.Name} does not have an inventory.");
                return;
            }

            if (!entityInventory.Items.ContainsKey(itemName))
            {
                Console.WriteLine($"Cannot equipt {itemName}, doesn't exist in inventory.");
                return;
            }

            entity.EquiptedItem = entityInventory.Items[itemName];
        }

        public static void EntityDropsItem(IEntity entity, string itemName)
        {
            if (entity is not IInventory entityInventory)
            {
                Console.WriteLine($"{entity.Name} does not have an inventory.");
                return;
            }

            if (!entityInventory.Items.ContainsKey(itemName))
            {
                Console.WriteLine($"Cannot drop {itemName}, doesn't exist in inventory.");
                return;
            }

            entityInventory.Items.Remove(itemName);
        }

        public static void EntityPicksUpItem(IEntity entity, IItem item)
        {
            if (entity is not IInventory entityInventory)
            {
                Console.WriteLine($"{entity.Name} does not have an inventory.");
                return;
            }

            if (entityInventory.Items.ContainsKey(item.Name))
            {
                //item in inventory
                if (item is not IStackable stackableItem)
                {
                    Console.WriteLine("Item already in inventory.");
                    return;
                }
                stackableItem.Quantity.Add(1);
            }
            else
            {
                //item not in inventory
                if (entityInventory.Items.Count > 5)
                {
                    Console.WriteLine("Cannot have more than 5 items in inventory.");
                    return;
                }
                entityInventory.Items.Add(item.Name, item);
            }
        }
    }
}
