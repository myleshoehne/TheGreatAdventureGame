namespace TheGreatAdventureGame.Models
{
    public enum Rarity
    {
        Common,
        Uncommon, 
        Rare, 
        Epic, 
        Legendary
    }

    /// <summary>
    /// Represents the type of effect applied to a vital (e.g., health, stamina).
    /// </summary>
    public enum VitalEffectType
    {
        Positive, 
        Negative,
        Random
    }

    public enum SurvivalVitalType
    {
        Health,
        Hunger,
        Thirst, 
        Random
    }
}
