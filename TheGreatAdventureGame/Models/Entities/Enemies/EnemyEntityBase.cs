using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Enemies
{
    public abstract class EnemyEntityBase : EntityBase, ICombatant, ISelfHealing
    {
        public abstract NumberRange HealImpactRange { get; set; }

        public virtual void DealWeaponEffect(IEntity targetEntity) => CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        public virtual void TakeWeaponEffect(string weaponInstanceId) => CombatManager.EntityTakesEffectFromWeapon(this, weaponInstanceId);
        public virtual void HealSelf() => CombatManager.EntityHealsSelf(this);

        protected EnemyEntityBase() { }
        protected EnemyEntityBase(int maxHealth) : base(maxHealth) { }
    }
}
