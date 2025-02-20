using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Enemies
{
    public abstract class EnemyEntityBase : EntityBase, ICombatant, ISelfHealing
    {
        public abstract NumberRange HealImpactRange { get; set; }

        public void DealWeaponEffect(IEntity targetEntity) => CombatManager.EntityDealsWeaponEffect(this, targetEntity);
        public void TakeWeaponEffect(string weaponInstanceId) => CombatManager.EntityTakesEffectFromWeapon(this, weaponInstanceId);
        public virtual void HealSelf()
        {
            //TODO: self heal logic
            Console.WriteLine("HEALED SELF");
        }

        
    }
}
