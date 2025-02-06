namespace TheGreatAdventureGame.Models.Items
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        NumberRange HealthEffectRange { get; set; }
        HealthEffectType HealthEffectType { get; set; }
        Rarity Rarity { get; set; }
        Vital RemainingUses { get; set; }
        IEntity? Target { get; set; }
        void Use();
    }
}
