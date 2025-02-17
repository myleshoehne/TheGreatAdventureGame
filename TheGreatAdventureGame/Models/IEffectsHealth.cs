namespace TheGreatAdventureGame.Models
{
    public interface IEffectsHealth
    {
        NumberRange HealthEffectRange { get; set; }
        HealthEffectType HealthEffectType { get; set; }
    }
}
