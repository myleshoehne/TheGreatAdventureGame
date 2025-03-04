using Microsoft.AspNetCore.Mvc;

namespace TheGreatAdventureGame.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
