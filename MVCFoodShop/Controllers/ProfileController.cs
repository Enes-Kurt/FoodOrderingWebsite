using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Data;

namespace MVCFoodShop.Controllers
{
    public class ProfileController : Controller
    {
        private readonly FoodShopDbContext context;

        public ProfileController(FoodShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult MyProfile()
        {
            
            return View();
        }

        public IActionResult ProfileSettings()
        {
            return PartialView("_ProfileSettings");
        }

        public IActionResult ChangePassword()
        {
            return PartialView("_ChangePassword");
        }

        public IActionResult Addresses()
        {
            return PartialView("_Addresses");
        }
    }
}
