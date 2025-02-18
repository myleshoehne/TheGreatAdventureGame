namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IEffectsVitals
    {
        NumberRange VitalEffectRange { get; set; }
        VitalEffectType VitalEffectType { get; set; }
        SurvivalVitalType EffectSurvivalVitalType { get; set;}
    }
}
