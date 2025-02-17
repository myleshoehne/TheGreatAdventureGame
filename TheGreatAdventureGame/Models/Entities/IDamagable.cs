namespace TheGreatAdventureGame.Models.Entities
{
    public interface IDamagable : IHealth
    {
        void TakeDamage(int damage);
    }
}
