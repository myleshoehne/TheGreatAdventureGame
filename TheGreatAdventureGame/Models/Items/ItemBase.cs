using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items
{
    public abstract class ItemBase : IItem
    {
        public string ItemTypeID => $"{GetType().Name.ToLower()}_{this.Rarity.ToString().ToLower()}";
        public string InstanceID => Guid.NewGuid().ToString();
        public abstract string Name { get; }
        public abstract string Description { get; }
        public Rarity Rarity { get; set; } 

        protected ItemBase() 
        { 
            this.Rarity = ItemHelper.GenerateRarity(); 
        }
        protected ItemBase(Rarity rarity)
        {
            this.Rarity = rarity;
        }
    }
}
