namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        /// <summary>
        /// Gets or sets the rarity level of the item.
        /// </summary>
        /// <remarks>
        /// If not explicitly set, the <see cref="Models.Rarity"/> will be randomly assigned upon item creation.
        /// </remarks>
        Rarity Rarity { get; set; }
    }
}
