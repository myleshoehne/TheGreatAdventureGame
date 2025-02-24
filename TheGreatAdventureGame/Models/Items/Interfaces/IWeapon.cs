using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IWeapon : IVitalEffects
    {
        NumberRange AttackEffectRange { get; set; }
    }
}
