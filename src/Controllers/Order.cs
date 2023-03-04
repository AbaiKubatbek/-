using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
