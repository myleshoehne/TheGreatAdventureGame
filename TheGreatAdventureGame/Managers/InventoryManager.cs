using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Managers
{
    public class InventoryManager
    {
        public static void EntityEquiptsItem(IEntity entity, string itemInstanceId)
        {
            //TODO: implement equipt logic 
            Console.WriteLine($"{entity.Name} equipt item with id: {itemInstanceId}");
        }

        public static void EntityDropsItem(IEntity entity, string itemInstanceId)
        {
            //TODO: implement drop logic 
            Console.WriteLine($"{entity.Name} dropped item with id: {itemInstanceId}");
        }

        public static void EntityPicksUpItem(IEntity entity, string itemInstanceId)
        {
            //TODO: implement pick up logic 
            Console.WriteLine($"{entity.Name} picked up item with id: {itemInstanceId}");
        }
    }
}
