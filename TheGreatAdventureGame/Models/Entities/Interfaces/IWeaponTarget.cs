using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IWeaponTarget
    {
        void TakeWeaponEffect(IWeapon weapon);
    }
}
