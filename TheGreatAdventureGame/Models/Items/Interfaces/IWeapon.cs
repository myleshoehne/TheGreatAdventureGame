using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IWeapon : IItem, IEffectsVitals
    {
        void DealEffectToEntity(IEntity entity);
    }
}
