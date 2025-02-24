using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface ICombatant
    {
        void DealWeaponEffect(ICombatant targetEntity);
        void TakeWeaponEffect(IWeapon usedWeapon);
    }
}
