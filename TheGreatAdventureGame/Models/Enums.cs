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
    /// Defines how an item affects a vital stat (e.g., improves, worsens, or is unpredictable).
    /// </summary>
    public enum EffectType
    {
        Positive,
        Negative,
        Random
    }

    /// <summary>
    /// Represents a type of vital stat that an item can affect (e.g., health, hunger, thirst).
    /// </summary>
    public enum VitalType
    {
        Health,
        Hunger,
        Thirst,
        Random
    }
}
