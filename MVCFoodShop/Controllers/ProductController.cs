using Microsoft.AspNetCore.Mvc;

namespace MVCFoodShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
