using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public abstract NumberRange AttackEffectRange { get; set; }
        public virtual EffectType EffectType { get; set; } = EffectType.Negative;
        public virtual VitalType TargetVital { get; set; } = VitalType.Health;

        protected WeaponBase() { }
        protected WeaponBase(Rarity rarity) : base(rarity)
        {
        }

        //TODO: add more contructors
    }
}
