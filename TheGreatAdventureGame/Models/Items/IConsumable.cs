using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items
{
    public interface IConsumable : IEffectsHealth
    {
        void Consume(IEntity entity);
    }
}
