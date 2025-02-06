using TheGreatAdventureGame.Helpers;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class WeaponBase : IItem
    {
        public string Name { get; set; } = "No Name";
        public string Description { get; set; } = "No Descirption";
        public NumberRange HealthEffectRange { get; set; } = new NumberRange(0, 0);
        public HealthEffectType HealthEffectType { get; set; } = HealthEffectType.Negative;
        public Rarity Rarity { get; set; } = ItemHelper.GenerateRarity();
        public IEntity? Target { get; set; }
        //Durability
        public Vital RemainingUses { get; set; } = new Vital(0);

        public WeaponBase() { }
        public WeaponBase(Rarity rarity)
        {
            this.Rarity = rarity;
        }

        public void Attack(IEntity target)
        {
            //take damage on target
        }
        public void Use()
        {
            //attack method call
        }
    }
}
