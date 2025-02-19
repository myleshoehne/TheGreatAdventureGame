using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Levels.Interfaces
{
    public interface ISingleEnvironmentItem
    {
        IItem EnvironmentItem { get; set; }
    }
}
