using Microsoft.AspNetCore.Http.Features;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Levels.Interfaces
{
    public interface ILevel
    {
        string Name { get; }
        string Description { get; }
        Player Player { get; }
        bool IsPlayerTurn { get; }
        bool Start();
        void NextTurn();
    }
}
