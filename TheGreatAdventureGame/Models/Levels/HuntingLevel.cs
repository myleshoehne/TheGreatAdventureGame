using System.Collections;
using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;
using TheGreatAdventureGame.Models.Levels.Interfaces;

namespace TheGreatAdventureGame.Models.Levels
{
    public class HuntingLevel : ILevel
    {
        public string LevelTypeID { get; }

        public string InstanceID { get; }

        public string Name { get; }

        public string Description { get; }

        public Player? Player { get; set; }

        public IEntity? Entity { get; }

        public bool IsPlayerTurn { get; set; }
        public bool Cleared { get; set; }
        public Dictionary<int, IItem> EnvironmentItems { get; set; }

        public HuntingLevel(Player player, int numItems = 3)
        {
            this.LevelTypeID = $"{this.GetType().Name}";
            this.InstanceID = Guid.NewGuid().ToString();
            this.Name = "Hunting";
            this.Description = "Hunting level desc...";
            this.Player = player;
            this.EnvironmentItems = new Dictionary<int, IItem>();

            for (int i = 0; i < numItems; i++)
            {
                Random random = new Random();

                int randomPercent = random.Next(1, 101);
                IItem randomItem = ItemHelper.GetRandomItem();

                this.EnvironmentItems.Add(randomPercent, randomItem);
            }

            this.IsPlayerTurn = true;
            this.Cleared = false;
        }
    }
}
