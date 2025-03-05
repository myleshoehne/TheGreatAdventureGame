using TheGreatAdventureGame.Helpers;

namespace TheGreatAdventureGame.Models
{
    public class NumberRange
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public NumberRange(int baseMin, int baseMax)
        {
            this.Min = baseMin;
            this.Max = baseMax;
        }

        public int GetRandomValueFromBaseRange()
        {
            Random rnd = new Random();
            return rnd.Next(this.Min, this.Max + 1);
        }
        public int GetRandomValueFromRarityRange(Rarity rarity)
        {
            decimal multiplier = ItemHelper.GetRarityMultiplier(rarity);

            int minWithRarity = (int)Math.Round(this.Min * multiplier);
            int maxWithRarity = (int)Math.Round(this.Max * multiplier);

            Random rnd = new Random();
            return rnd.Next(minWithRarity, maxWithRarity + 1);
        }
    }
}
