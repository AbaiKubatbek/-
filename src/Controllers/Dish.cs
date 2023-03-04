using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class Dish : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
