using Microsoft.AspNetCore.Mvc;

namespace MVCFoodShop.Controllers
{
    public class ProfileController : Controller
    {

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
