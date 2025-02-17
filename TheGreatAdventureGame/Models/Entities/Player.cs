using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities
{
    public class Player : IEntity, ISurvivalVitals, IInventory
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IItem? EquiptedItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vital Hunger { get; set; } = new Vital(100);
        public Vital Thirst { get; set; } = new Vital(100);
        public Vital Health { get; set; } = new Vital(100);
        public Dictionary<int, IItem> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DropItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void EquiptItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void PickUpItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void Heal(int amount)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
