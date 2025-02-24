namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface ISelfHealing
    {
        NumberRange HealEffectRange { get; set; }
        void HealSelf();
    }
}
