using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IEntity
    {
        //TODO: add IDs, then we can serialize this 
        string Name { get; set; }
        string Description { get; set; }
        Vital Health { get; set; }
        IItem? EquiptedItem { get; set; }
    }
}
