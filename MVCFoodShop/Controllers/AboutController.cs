using Microsoft.AspNetCore.Mvc;

namespace MVCFoodShop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
