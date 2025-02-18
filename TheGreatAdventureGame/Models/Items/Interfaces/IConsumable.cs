using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IConsumable : IItem, IEffectsVitals
    {
        void ConsumedByEntity(IEntity entity);
    }
}
