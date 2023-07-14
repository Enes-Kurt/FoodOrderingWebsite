using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;

        public ProfileController(UserManager<AppUser> userManager, IAppUserRepository appUserRepository)
        {

            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
        }

        public IActionResult MyProfile()
        {
            int userıd = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userıd);
            return View(user);
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
