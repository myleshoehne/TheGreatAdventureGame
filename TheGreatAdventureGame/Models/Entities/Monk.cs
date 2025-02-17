using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities
{
    public class Monk : IEntity, IDamagable, IHealable
    {
        public string Name { get; set; } = "Monk";
        public string Description { get; set; } = "Monk Description here";
        public Vital Health { get; set; } = new Vital(100);
        public IItem? EquiptedItem { get; set; } // give monk a staff


        public void DamageSurvialVital(IWeapon weapon)
        {
            throw new NotImplementedException();
        }

        public void HealSurvialVital(IConsumable consumable)
        {
            throw new NotImplementedException();
        }
    }
}
