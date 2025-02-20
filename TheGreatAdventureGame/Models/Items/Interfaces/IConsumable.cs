﻿using TheGreatAdventureGame.Models.Entities.Interfaces;

namespace TheGreatAdventureGame.Models.Items.Interfaces
{
    public interface IConsumable : IVitalEffects
    {
        NumberRange NutritionValueRange { get; set; }
    }
}
