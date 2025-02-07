namespace TheGreatAdventureGame.Models.Entities
{
    public class Monk : IEntity, IDamagable, IHealth
    {
        public string Name { get; set; } = "Monk";
        public string Description { get; set; } = "Monk Description here";
        public Vital Health { get; set; } = new Vital(100);

        public void TakeDamage(int damage)
        {
            this.Health.Subtract(damage);
        }
    }
}
