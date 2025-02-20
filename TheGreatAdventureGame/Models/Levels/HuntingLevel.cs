using TheGreatAdventureGame.Models.Entities.Players;
using TheGreatAdventureGame.Models.Items.Consumables.Food;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;
using TheGreatAdventureGame.Models.Levels.Interfaces;

namespace TheGreatAdventureGame.Models.Levels
{
    public class HuntingLevel : ILevel, IMultipleEnvironmentItems
    {
        private Player _player;

        public string Name => "Hunting Level";

        public string Description => "The player is presented with three targets, each containing different items and buffs. Each target has a certain percentage chance to be hit. " +
            "If the player successfully hits a target, they receive the item or buff associated with it. If the player misses a target, they lose health.";

        public Player Player => _player;

        public bool IsPlayerTurn => throw new NotImplementedException();

        public Dictionary<string, IItem> EnvironmentItems => new Dictionary<string, IItem>();

        public HuntingLevel(Player player)
        {
            _player = player;

            //Randomly generate itmes
            //TODO: make this randomly generative
            this.EnvironmentItems.Add("Sword", new Sword());
            this.EnvironmentItems.Add("Apple", new Apple());
            this.EnvironmentItems.Add("Crossbow", new Crossbow());
        }

        //TODO: not sure how we are going to go about this with controllers
        public void NextTurn()
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            throw new NotImplementedException();
        }
    }
}
