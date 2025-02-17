using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Crossbow : IWeapon, IBreakable
    {
        public string Name { get; set; } = "Crossbow";
        public string Description { get; set; } = "Crossbow description here..";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public Vital Durability { get; set; } = new Vital(100);
        public NumberRange EffectRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public HealthEffectType EffectType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SurvivalVitalType EffectSurvivalVitalType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DealDamageToEntity(IEntity? entity)
        {
            throw new NotImplementedException();
        }
    }
}
