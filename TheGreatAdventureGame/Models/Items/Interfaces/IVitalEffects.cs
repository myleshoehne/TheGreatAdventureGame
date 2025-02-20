namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IVitalEffects
    {
        VitalImpactType ImpactType { get; set; }
        VitalCategoryType TargetVital { get; set; }
    }
}
