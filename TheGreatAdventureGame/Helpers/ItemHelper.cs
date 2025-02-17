using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Items;

namespace TheGreatAdventureGame.Helpers
{
    public class ItemHelper
    {
        

        /// <summary>
        /// Generates a rarity based on predefined weighted probabilities.
        /// More common rarities have a higher chance of being selected.
        /// </summary>
        /// <returns>
        /// A <see cref="Rarity"/> value representing the selected rarity.
        /// </returns>
        public static Rarity GenerateRarity()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 101);

            if (roll < 51) return Rarity.Common;
            if (roll < 76) return Rarity.Uncommon;
            if(roll < 91) return Rarity.Rare;
            if (roll < 98) return Rarity.Epic;
            return Rarity.Legendary;
        }

        /// <summary>
        /// Gets a rarity's mutliplier.
        /// The higher the rarity the higher the multiplier.
        /// </summary>
        /// <returns>
        /// A <see cref="decimal"/> value representing the passed in rarity's multiplier.
        /// </returns>
        public static decimal GetRarityMultiplier(Rarity rarity)
        {
            if (rarity == Rarity.Common) return 1m;
            if (rarity == Rarity.Uncommon) return 1.25m;
            if (rarity == Rarity.Rare) return 1.5m;
            if (rarity == Rarity.Epic) return 2m;
            return 3m;
        }


        
    }
}
