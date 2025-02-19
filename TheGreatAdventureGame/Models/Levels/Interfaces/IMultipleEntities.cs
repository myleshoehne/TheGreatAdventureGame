using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Levels.Interfaces
{
    public interface IMultipleEntities
    {
        Dictionary<string, IEntity> Entities { get; }
    }
}
