﻿namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IBreakable
    {
        Vital Durability { get; set; }
        NumberRange DurabilityEffectRange { get; set; }
    }
}
