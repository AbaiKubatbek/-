using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class Courier : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
