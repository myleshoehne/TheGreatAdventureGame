using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public abstract class WeaponBase : IWeapon
    {
        //TODO: make item base with props that are in weapon/consumable base
        public int ItemID { get; } 
        public string InstanceID => Guid.NewGuid().ToString();
        public string Name { get; } 
        public string Description { get; }
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public abstract NumberRange AttackPowerRange { get; set; }
        public VitalEffectType EffectType { get; set; } = VitalEffectType.Positive;
        public SurvivalVitalType TargetVital { get; set; } = SurvivalVitalType.Health;

        protected WeaponBase(string name, string desc, int itemId)
        {
            this.Name = name;
            this.Description = desc;
            this.ItemID = itemId;
        }

        protected WeaponBase(string name, string desc, int itemId, Rarity rarity)
        {
            this.Name = name;
            this.Description = desc;
            this.ItemID = itemId;
            this.Rarity = rarity;
        }
    }
}
