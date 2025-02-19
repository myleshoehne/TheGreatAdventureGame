using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IWeaponOperator
    {
        void DealWeaponEffect(IEntity targetEntity);
    }
}
