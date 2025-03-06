using Microsoft.AspNetCore.Http.Features;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Levels.Interfaces
{
    public interface ILevel
    {
        string LevelTypeID { get; } 
        string InstanceID { get; }
        string Name { get; }
        string Description { get; }
        Player Player { get; }
        IEntity? Entity { get; }
        Dictionary<int, IItem> EnvironmentItems { get; set; }
        bool IsPlayerTurn { get; set; }
        bool Cleared { get; set; }
    }
}
