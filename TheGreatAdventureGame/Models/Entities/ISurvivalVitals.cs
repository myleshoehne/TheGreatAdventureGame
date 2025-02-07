namespace TheGreatAdventureGame.Models.Entities
{
    public interface ISurvivalVitals : IHealth
    {
        Vital Hunger { get; set; }
        Vital Thirst { get; set; }
    }
}
