using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class Restorant : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
