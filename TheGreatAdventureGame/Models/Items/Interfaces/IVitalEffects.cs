namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IVitalEffects
    {
        EffectType EffectType { get; set; }
        VitalType TargetVital { get; set; }
    }
}
