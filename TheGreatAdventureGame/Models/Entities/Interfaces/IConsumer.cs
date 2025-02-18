using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Interfaces
{
    public interface IConsumer
    {
        void Consume(IConsumable consumable);
    }
}
