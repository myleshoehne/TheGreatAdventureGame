using Microsoft.AspNetCore.Mvc;
using TheGreatAdventureGame.State;
using TheGreatAdventureGame.ViewModels;

namespace TheGreatAdventureGame.Controllers
{
    public class PlayerCreationController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View(new PlayerCreationViewModel());
        }

        [HttpPost]
        public IActionResult Create(PlayerCreationViewModel playerCreation)
        {
            return RedirectToAction("Confirm", "PlayerCreation", playerCreation);
        }

        [HttpGet]
        public IActionResult Confirm(PlayerCreationViewModel playerCreation)
        {
            return View(playerCreation);
        }

        [HttpPost]
        public IActionResult Confirm(PlayerCreationViewModel playerCreation, string action)
        {
            
            if (action == "edit")
            {
                return RedirectToAction("Edit", "PlayerCreation", playerCreation);
            }
            else if (action == "confirm")
            {
                //when back we are just going to add player to gamecontext here
                return RedirectToAction("Start", "Adventure", playerCreation);
            }

            return View(playerCreation);
        }

        [HttpGet]
        [ActionName("Edit")]
        public IActionResult EditGet(PlayerCreationViewModel playerCreation)
        {
            return View(playerCreation);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(PlayerCreationViewModel playerCreation)
        {
            return RedirectToAction("Confirm", "PlayerCreation", playerCreation);
        }
    }
}
