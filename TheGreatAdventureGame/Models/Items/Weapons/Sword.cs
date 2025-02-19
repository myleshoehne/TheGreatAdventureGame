using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : WeaponBase, IBreakable
    {

        public Vital Durability { get; set; } = new Vital(100);
        public override NumberRange AttackPowerRange { get; set; } = new NumberRange(5, 10);

        //Guarenteed Sword values 
        private static readonly string _name = "Sword";
        private static readonly string _desc = "Sword Description here..."; //TODO: Add description for sword
        private static readonly int _itemId = 1; 

        public Sword() : base(_name, _desc, _itemId) { }
        public Sword(Rarity rarity) : base(_name, _desc, _itemId, rarity)
        {
        }
    }
}
