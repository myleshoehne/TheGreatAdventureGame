namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : WeaponBase
    {
        public Sword() : base()
        {
            Initialize();
        }
        public Sword(Rarity rarity) : base(rarity)
        {
            Initialize();
        }

        public void Initialize()
        {
            this.Name = "Sword";
            this.Description = "This is a sword. Deals a base damage of 10-15.";
            this.HealthEffectRange = new NumberRange(10, 15);
            this.RemainingUses = new Vital(100);
        }
    }
}
