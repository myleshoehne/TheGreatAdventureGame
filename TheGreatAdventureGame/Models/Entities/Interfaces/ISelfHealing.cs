namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface ISelfHealing
    {
        NumberRange HealImpactRange { get; set; }
        void HealSelf();
    }
}
