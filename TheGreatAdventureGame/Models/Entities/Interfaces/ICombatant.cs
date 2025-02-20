using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface ICombatant
    {
        void DealWeaponEffect(IEntity targetEntity);
        void TakeWeaponEffect(string weaponInstanceId);
    }
}
