using Microsoft.AspNetCore.Mvc;

namespace MVCFoodShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
