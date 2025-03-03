using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class InventoryManager
    {
        //TODO: need to add functionality for environment, so if entity drops an item it goes to the environment
        public static void EntityEquiptsItem(IInventory inventoryEntity, IItem item)
        {
            IEntity entity = (IEntity)inventoryEntity;

            if (!inventoryEntity.Inventory.ContainsKey(item.ItemTypeID))
            {
                // Entity doesn't have item in inventory
                Console.WriteLine($"{entity.Name} does not have {item.Name} in inventory.");
                return;
            }

            entity.EquippedItem = inventoryEntity.Inventory[item.ItemTypeID];
        }

        public static void EntityDropsItem(IInventory inventoryEntity, IItem? dropItem = null)
        {

            IEntity entity = (IEntity)inventoryEntity;

            if(dropItem == null)
            {
                if(entity.EquippedItem == null)
                {
                    // No item to drop
                    Console.WriteLine($"No item to drop.");
                    return;
                }
                // Default to drop equipt item if no dropItem is provident
                dropItem = entity.EquippedItem;

                // Remove dropped item from Equipped slot 
                entity.EquippedItem = null;
            }

            //TODO: add dropped item to environment here

            // Remove from inventory
            inventoryEntity.Inventory.Remove(dropItem.ItemTypeID);
        }

        public static void EntityPicksUpItem(IInventory inventoryEntity, IItem pickUpItem)
        {
            if (inventoryEntity.Inventory.Count < inventoryEntity.InventoryCapacity)
            {
                if (inventoryEntity.Inventory.ContainsKey(pickUpItem.ItemTypeID))
                {
                    // Item of same type is already in inventory
                    if (pickUpItem is IStackable stackablePickUpItem && inventoryEntity.Inventory[pickUpItem.ItemTypeID] is IStackable stackableInventoryItem)
                    {
                        // Item is stackable
                        int quantity = stackablePickUpItem.Quantity.Current;

                        int? quantityLeftOver = stackableInventoryItem.Quantity.Add(quantity);

                        if (quantityLeftOver.HasValue)
                        {
                            // TODO: push back out to the environment here
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{pickUpItem.Name} is already in inventory.");
                    }

                }
                else
                {
                    inventoryEntity.Inventory.Add($"{pickUpItem.ItemTypeID}", pickUpItem);
                }
            }
            else
            {
                Console.WriteLine("Player doesn't have enough room in inventory.");
            }
        }

    }
} 
