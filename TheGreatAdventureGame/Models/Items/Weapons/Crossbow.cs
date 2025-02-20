using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Crossbow : WeaponBase, IBreakable
    {
        public override int ItemID => 2;
        public override string Name { get; } = "Crossbow";
        public override string Description { get; } = "Crossbow description here..";
        public override NumberRange AttackImpactRange { get; set; } = new NumberRange(7, 13);
        public Vital Durability { get; set; } = new Vital(100);
        

        public Crossbow() { }
        public Crossbow(Rarity rarity)
        {
            this.Rarity = rarity;
        }
    }
}
