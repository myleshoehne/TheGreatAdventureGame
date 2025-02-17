using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items
{
    public interface IDealsDamage : IEffectsHealth
    {    
        void DealDamage(IEntity? entity);
    }
}
