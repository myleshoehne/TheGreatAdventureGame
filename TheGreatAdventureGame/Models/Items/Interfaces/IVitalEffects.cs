namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IVitalEffects
    {
        VitalEffectType EffectType { get; set; }
        SurvivalVitalType TargetVital { get; set; }
    }
}
