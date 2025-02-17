using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IHealable
    {
        void HealSurvialVital(IConsumable consumable);
    }
}
