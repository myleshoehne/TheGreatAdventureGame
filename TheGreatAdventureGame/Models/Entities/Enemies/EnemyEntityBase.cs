using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Enemies
{
    public abstract class EnemyEntityBase : EntityBase, ICombatant, ISelfHealing
    {
        public abstract NumberRange HealEffectRange { get; set; }

        public virtual void DealWeaponEffect(ICombatant targetEntity) => CombatManager.EntityDealsWeaponEffect(targetEntity);
        public virtual void TakeWeaponEffect(IWeapon usedWeapon) => CombatManager.EntityTakesEffectFromWeapon(this, usedWeapon);
        public virtual void HealSelf() => CombatManager.EntityHealsSelf(this);

        protected EnemyEntityBase() { }
        protected EnemyEntityBase(int maxHealth) : base(maxHealth) { }
    }
}
