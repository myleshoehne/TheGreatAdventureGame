namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IVitalEffects
    {
        //TODO: make target vital a flag so it can affect multiple vitals if needed
        EffectType EffectType { get; set; }
        VitalType TargetVital { get; set; }
    }
}
