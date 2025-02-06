namespace TheGreatAdventureGame.Models.Items
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        NumberRange HealthEffectRange { get; set; }
        HealthEffectType HealthEffectType { get; set; }
        Rarity Rarity { get; set; }

        /// <summary>
        /// Gets or sets the remaining uses of the item (e.g., durability for weapons or quantity for consumables).
        /// When the value reaches 0, the item is considered depleted and may be removed.
        /// </summary>
        Vital RemainingUses { get; set; }
        IEntity? Target { get; set; }
        void Use();
    }
}
