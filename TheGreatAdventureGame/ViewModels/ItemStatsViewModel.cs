using TheGreatAdventureGame.Models;

namespace TheGreatAdventureGame.ViewModels
{
    public class ItemStatsViewModel
    {
        public string InstanceID { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public Rarity Rarity { get; set; }
        public string EffectType { get; set; }
        public string TargetVital { get; set; }
        public string? NutritionValueRange { get; set; }
        public string? AttackEffectRange { get; set; }
    }
}
