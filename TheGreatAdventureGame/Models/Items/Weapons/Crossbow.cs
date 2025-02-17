using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Crossbow : IItem, IDealsDamage, IBreakable
    {
        public string Name { get; set; } = "Crossbow";
        public string Description { get; set; } = "Crossbow description here..";
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public NumberRange HealthEffectRange { get; set; } = new NumberRange(20, 30);
        public HealthEffectType HealthEffectType { get; set; } = HealthEffectType.Negative;
        public Vital Durability { get; set; } = new Vital(100);

        public void DealDamage(IEntity? entity)
        {
            ItemManager.DealDamage(entity, this);
        }
    }
}
