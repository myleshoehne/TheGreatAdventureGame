using System.Text.Json.Serialization;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Entities.Players
{
    public class Player : PlayerEntityBase
    {
        public override string Name { get; set; }

        public override string Description => "Player desc...";

        public Player(string name)
        {
            this.Name = name;
        }
        public Player(string name, int maxHealth, int maxHunger, int maxThirst) : base(maxHealth, maxHunger, maxThirst)
        {
            this.Name = name;
        }
    }
}
