namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IItem
    {
        /// <summary>
        /// Gets the unique identifier for a specific item type (e.g., Sword, Crossbow, etc.).
        /// </summary>
        /// <remarks>
        /// This value is predefined and remains constant for all instances of the same item type.
        /// </remarks>
        int ItemID { get; }

        /// <summary>
        /// Gets the unique identifier for a specific item instance.
        /// </summary>
        /// <remarks>
        /// This value is dynamically generated for each individual item instance to ensure uniqueness.
        /// </remarks>
        string InstanceID { get; }
        string Name { get; }
        string Description { get; }
        /// <summary>
        /// Gets or sets the rarity level of the item.
        /// </summary>
        /// <remarks>
        /// If not explicitly set, the <see cref="Models.Rarity"/> will be randomly assigned upon item creation.
        /// </remarks>
        Rarity Rarity { get; set; }
    }
}
