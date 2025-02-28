using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities
{
    public abstract class EntityBase : IEntity
    {
        public string EntityTypeID => this.GetType().Name.ToLower();
        public string InstanceID => Guid.NewGuid().ToString();
        public abstract string Name { get; set; }
        public abstract string Description { get; }
        public Vital Health { get; set; }
        public virtual IItem? EquippedItem { get; set; }

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
