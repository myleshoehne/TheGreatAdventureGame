using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : WeaponBase, IBreakable
    {
        public override int ItemID => 1;
        public override string Name => "Sword";
        public override string Description => "Sword description here...";
        public override NumberRange AttackImpactRange { get; set; } = new NumberRange(5, 10);
        public Vital Durability { get; set; } = new Vital(100);
        
        public Sword() { }
        public Sword(Rarity rarity) : base(rarity)
        {
        }
    }
}
