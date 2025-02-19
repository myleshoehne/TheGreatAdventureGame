using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Levels.Interfaces
{
    public interface IMultipleEnvironmentItems
    {
        Dictionary<string, IItem> EnvironmentItems { get; }
    }
}
