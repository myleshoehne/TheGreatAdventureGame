using System.CodeDom.Compiler;
using System.Reflection;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Items;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Helpers
{
    public class ItemHelper
    {
        public static readonly Dictionary<Type, string> ItemImagePaths = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IItem).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t, t => $"~/images/{t.Name.ToLower()}.png");
            

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

        public static string GetRarityStyle(Rarity rarity)
        {
            return rarity switch
            {
                Models.Rarity.Common => "background: linear-gradient(135deg, #9e9e9e, #616161); border-color: #757575;",
                Models.Rarity.Uncommon => "background: linear-gradient(135deg, #4caf50, #1b5e20); border-color: #2E7D32;",
                Models.Rarity.Rare => "background: linear-gradient(135deg, #2196f3, #0d47a1); border-color: #1976D2;",
                Models.Rarity.Epic => "background: linear-gradient(135deg, #9c27b0, #6a1b9a); border-color: #8E24AA; box-shadow: 0px 0px 10px #9c27b0;",
                Models.Rarity.Legendary => "background: linear-gradient(135deg, #ffd700, #ff8f00); border-color: #FFAA00; box-shadow: 0px 0px 15px #ffd700;",
                _ => "background: white; border-color: gray;"
            };
        }

        public static string GetItemImage(IItem item)
        {
            Type itemType = item.GetType();

            if (ItemImagePaths.ContainsKey(itemType))
            {
                return ItemImagePaths[itemType];
            }

            throw new ArgumentException($"Need to add image for {item.Name}, or change image name to match the item name: {item.Name.ToLower()}.png");
        }

        /// <summary>
        /// Gets a random value from the specified enum type. If the randomly selected value is "Random", 
        /// the method will recursively call itself to get a new random value until a non-"Random" value is selected.
        /// </summary>
        /// <typeparam name="T">The enum type from which to select a random value. The type must be an enum.</typeparam>
        /// <returns>A randomly selected value of the specified enum type, excluding the value "Random".</returns>
        /// <exception cref="InvalidOperationException">Thrown if an invalid enum value is encountered during the process.</exception>
        public static T GetRandomEnumValue<T>() where T : Enum
        {
            int roll = GetEnumRoll<T>();

            T? enumValue = (T?)Enum.GetValues(typeof(T)).GetValue(roll);

            if(enumValue == null || enumValue.Equals(Enum.GetValues(typeof(T)).Cast<T>().FirstOrDefault(v => v.ToString() == "Random")))
            {
                return GetRandomEnumValue<T>();
            }

            return enumValue;
        }

        private static int GetEnumRoll<T>() where T : Enum
        {
            int EnumLength = Enum.GetValues(typeof(T)).Length;

            Random random = new Random();
            return random.Next(0, EnumLength); 
        } 
    }
}
