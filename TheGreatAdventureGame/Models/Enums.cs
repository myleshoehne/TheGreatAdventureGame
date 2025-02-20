namespace TheGreatAdventureGame.Models
{
    /// <summary>
    /// Represents the rarity of an item, which determines the multiplier applied to its stats or attributes.
    /// Higher rarity items are typically more powerful and unique, with their stats being multiplied by higher values.
    /// </summary>
    public enum Rarity
    {
        Common,
        Uncommon, 
        Rare, 
        Epic, 
        Legendary
    }

    /// <summary>
    /// Represents the type of impact or change applied to a vital category (e.g., health, hunger).
    /// This determines whether the effect improves, worsens, or has an unpredictable outcome.
    /// </summary>
    public enum VitalImpactType
    {
        Positive, 
        Negative,
        Random
    }

    /// <summary>
    /// Represents the category of a vital that is being affected by an item.
    /// Vital categories include essential survival stats such as health, hunger, and thirst.
    /// </summary>
    public enum VitalCategoryType
    {
        Health,
        Hunger,
        Thirst, 
        Random
    }
}
