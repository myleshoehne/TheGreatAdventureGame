using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : IWeapon, IBreakable
    {
        public string Name { get; set; } = "Sword";
        public string Description { get; set; } = "Sword description here...";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public Vital Durability { get; set; } = new Vital(100);
        public NumberRange VitalEffectRange { get; set; } = new NumberRange(5, 10);
        public VitalEffectType VitalEffectType { get; set; } = VitalEffectType.Negative;
        public SurvivalVitalType EffectSurvivalVitalType { get; set; } = SurvivalVitalType.Health;

        public Sword() { }
        public Sword(Rarity rarity)
        {
            this.Rarity = rarity;
        }
    }
}
