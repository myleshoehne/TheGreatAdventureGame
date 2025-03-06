using System.Reflection;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Levels.Interfaces;

namespace TheGreatAdventureGame.Helpers
{
    public class LevelHelper
    {
        public static readonly string[] AllLevelNames = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ILevel).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(t => t.Name)
            .ToArray();

        public static Dictionary<int, CatalogLevel> GenerateLevelCatalogData(int numLevels = 50)
        {
            Dictionary<int, CatalogLevel> LevelCatalogData = new();
            for(int i = 0; i < numLevels; i++)
            {
                int levelNum = i + 1;
                string levelName = GetRandomLevelName();

                LevelCatalogData.Add(levelNum, new CatalogLevel(levelName));
            }
            return LevelCatalogData;
        }

        public static string GetRandomLevelName()
        {
            int roll = GetLevelRoll();
            return AllLevelNames[roll];
        }

        private static int GetLevelRoll()
        {
            Random random = new Random();
            return random.Next(0, AllLevelNames.Length);
        }
    }
}
