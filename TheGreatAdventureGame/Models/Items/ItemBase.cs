using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items
{
    public abstract class ItemBase : IItem
    {
        public string ItemTypeID { get; }
        public string InstanceID { get; }
        public abstract string Name { get; }
        public abstract string Description { get; }
        public string ImageUrl { get; }
        public Rarity Rarity { get; set; }

        protected ItemBase() 
        {
            this.Rarity = ItemHelper.GenerateRarity();
            this.ItemTypeID = $"{GetType().Name.ToLower()}_{this.Rarity.ToString().ToLower()}";
            this.InstanceID = Guid.NewGuid().ToString();
            this.ImageUrl = ItemHelper.GetItemImage(this);
        }
        protected ItemBase(Rarity rarity)
        {
            this.Rarity = rarity;
            this.ItemTypeID = $"{GetType().Name.ToLower()}_{this.Rarity.ToString().ToLower()}";
            this.InstanceID = Guid.NewGuid().ToString();
            this.ImageUrl = ItemHelper.GetItemImage(this);
        }
    }
}
