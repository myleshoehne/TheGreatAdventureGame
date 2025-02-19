using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using TheGreatAdventureGame.Models.Entities;

namespace TheGreatAdventureGame.Pages
{
    public class ConfirmCreatedPlayerModel : PageModel
    {
        public Player CreatedPlayer { get; set; }

        public void OnGet()
        {
            // Get player from session 
            string serializedPlayer = HttpContext.Session.GetString("Player");

            // Deserialize player
            if(!string.IsNullOrEmpty(serializedPlayer))
            {
                this.CreatedPlayer = JsonSerializer.Deserialize<Player>(serializedPlayer);
            }
            else
            {
                this.CreatedPlayer = new Player();
            }
        }
    }
}
