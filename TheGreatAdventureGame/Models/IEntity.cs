namespace TheGreatAdventureGame.Models
{
    public interface IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        Vital Health { get; set; }
        //inventory 
        void PickUp();
        void Drop();

    }
}
