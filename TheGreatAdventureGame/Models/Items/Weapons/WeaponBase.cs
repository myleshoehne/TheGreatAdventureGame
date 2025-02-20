using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public abstract NumberRange AttackImpactRange { get; set; }
        public virtual VitalImpactType ImpactType { get; set; } = VitalImpactType.Negative;
        public virtual VitalCategoryType TargetVital { get; set; } = VitalCategoryType.Health;

        protected WeaponBase() { }
        protected WeaponBase(Rarity rarity) : base(rarity)
        {
        }

        //TODO: add more contructors
    }
}
