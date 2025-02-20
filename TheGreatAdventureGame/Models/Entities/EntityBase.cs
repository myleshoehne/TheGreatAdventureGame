using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities
{
    public abstract class EntityBase : IEntity
    {
        public abstract int EntityID { get; }
        public string InstanceID => Guid.NewGuid().ToString();
        public abstract string Name { get; }
        public abstract string Description { get; }
        public Vital Health { get; set; }
        public virtual string? EquiptItemInstanceID { get; set; } //TODO: make ItemHelper.GenerateRandomItemId();

        protected EntityBase() 
        {
            this.Health = new Vital(100);
        }

        protected EntityBase(int maxHealth)
        {
            this.Health = new Vital(maxHealth);
        }
    }
}
