namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IEffectsHealth
    {
        NumberRange EffectRange { get; set; }
        HealthEffectType EffectType { get; set; }
        SurvivalVitalType EffectSurvivalVitalType { get; set;}
    }
}
