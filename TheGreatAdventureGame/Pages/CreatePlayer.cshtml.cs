using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using TheGreatAdventureGame.Models;
using TheGreatAdventureGame.Models.Entities;
using TheGreatAdventureGame.Models.Items.Interfaces;
using TheGreatAdventureGame.Models.Items.Weapons;

namespace TheGreatAdventureGame.Pages
{
    public class CreatePlayerModel : PageModel
    {
        [BindProperty]
        public string? PlayerName { get; set; }

        [BindProperty]
        public string? StartingWeaponName { get; set; } 

        public List<IWeapon> StartingWeaponOptions { get; } = new()
        {
            new Sword(Rarity.Common),
            new Crossbow(Rarity.Common),
        };

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            //IWeapon SelectedWeapon = StartingWeaponOptions.FirstOrDefault(w => w.Name.Equals(StartingWeaponName, StringComparison.OrdinalIgnoreCase));

            ////Build new player based on inputs
            //Player NewPlayer = new Player()
            //{
            //    Name = PlayerName,
            //    EquiptedItem = SelectedWeapon,
            //};

            //// Store new player in session
            //string serializedPlayer = JsonSerializer.Serialize(NewPlayer);
            //HttpContext.Session.SetString("Player", serializedPlayer);

            //// Redirect
            //return RedirectToPage("/ConfirmCreatedPlayer", NewPlayer);
        }
    }
}
