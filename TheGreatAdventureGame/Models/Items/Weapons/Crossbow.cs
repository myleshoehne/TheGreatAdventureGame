using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Crossbow : IWeapon, IBreakable
    {
        public int ItemID => 2;

        public string InstanceID => Guid.NewGuid().ToString();
        public string Name { get; set; } = "Crossbow";
        public string Description { get; set; } = "Crossbow description here..";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public Vital Durability { get; set; } = new Vital(100);
        public SurvivalVitalType EffectSurvivalVitalType { get; set; } = SurvivalVitalType.Health;
        public NumberRange VitalEffectRange { get; set; } = new NumberRange(7, 13);
        public VitalEffectType VitalEffectType { get; set; } = VitalEffectType.Negative;

        

        public Crossbow() { }
        public Crossbow(Rarity rarity)
        {
            this.Rarity = rarity;
        }
    }
}
