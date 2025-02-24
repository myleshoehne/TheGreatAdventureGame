using System.Runtime.CompilerServices;
using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

namespace TheGreatAdventureGame.Models.Entities.Enemies
{
    public class Monk : EnemyEntityBase
    {
        public override int EntityID => 2;
        public override string Name { get; set; } = "Monk";
        public override string Description { get; } = "Monk Description here";
        public override string? EquiptItemInstanceID { get; set; } //TODO: make ItemHelper.GeneratorNewItemId(IItem item);
        public override NumberRange HealEffectRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
