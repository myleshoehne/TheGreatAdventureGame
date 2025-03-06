namespace TheGreatAdventureGame.Models
{
    public class CatalogLevel
    {
        public string Name { get; }
        public bool IsLocked { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsBeat { get; set; }
        public CatalogLevel(string name)
        {
            this.Name = name;
            this.IsLocked = true;
        }
    }
}
