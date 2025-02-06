using System.Buffers;

namespace TheGreatAdventureGame.Models.Items.Consumables
{
    public class ConsumableBase : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public NumberRange HealthEffectRange { get; set; }
        public HealthEffectType HealthEffectType { get; set; }
        public Rarity Rarity { get; set; }
        public IEntity? Target { get; set; }
        //Quantity
        public Vital RemainingUses { get; set; } = new Vital(0);


        public void Consume()
        {
            throw new NotImplementedException();
        }
        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
