using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items
{
    public interface IDealsDamage
    {
        NumberRange HealthEffectRange { get; set; }
        HealthEffectType HealthEffectType { get; set; }
        void DealDamage(IEntity? entity);
    }
}
