using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IConsumable : IItem, IEffectsHealth
    {
        void ConsumeBy(IEntity entity);
    }
}
