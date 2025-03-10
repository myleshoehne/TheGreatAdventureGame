﻿using TheGreatAdventureGame.Helpers;
using TheGreatAdventureGame.Managers;
using TheGreatAdventureGame.Models.Entities.Interfaces;
using TheGreatAdventureGame.Models.Items.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Weapons
{
    public class Sword : WeaponBase, IBreakable
    {    
        public override string Name => "Sword";
        public override string Description => "Sword description here...";
        public override NumberRange AttackEffectRange { get; set; } = new NumberRange(5, 10);
        public Vital Durability { get; set; } = new Vital(100);
        public virtual NumberRange DurabilityEffectRange { get; set; } = new NumberRange(1, 5);

        public Sword() { }
        public Sword(Rarity rarity) : base(rarity)
        {
        }
    }
}
