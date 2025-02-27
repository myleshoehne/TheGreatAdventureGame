using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Levels.Interfaces;

namespace TheGreatAdventureGame.State
{
    public class GameState
    {
        public Player? Player { get; set; }
        public List<ILevel> Levels { get; set; } = new();
    }
}
