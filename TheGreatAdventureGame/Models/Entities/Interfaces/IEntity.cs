using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IEntity
    {
        /// <summary>
        /// Gets the unique identifier for a specific entity type (e.g., Monk, Player, etc.).
        /// </summary>
        /// <remarks>
        /// This value is predefined and remains constant for all instances of the same entity type.
        /// </remarks>
        int EntityID { get; }

        /// <summary>
        /// Gets the unique identifier for a specific entity instance.
        /// </summary>
        /// <remarks>
        /// This value is dynamically generated for each individual entity instance to ensure uniqueness.
        /// </remarks>
        string InstanceID { get; }
        string Name { get; }
        string Description { get; }
        Vital Health { get; set; }
        string? EquiptItemInstanceID { get; set; }

        //TODO: make EquiptItem prop that fetches the item from the itemID
    }
}
