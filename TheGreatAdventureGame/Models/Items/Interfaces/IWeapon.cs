using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IWeapon : IItem, IEffectsHealth
    {
        void DealDamageToEntity(IEntity? entity);
    }
}
