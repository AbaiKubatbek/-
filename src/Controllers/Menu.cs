using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class Menu : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
