namespace TheGreatAdventureGame.Models.Items
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        Rarity Rarity { get; set; }
    }
}
