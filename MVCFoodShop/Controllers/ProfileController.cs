using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using NuGet.Protocol;

namespace MVCFoodShop.Controllers
{
    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IPasswordHasher<AppUser> passwordHasher;
        private readonly SignInManager<AppUser> signInManager;

        public ProfileController(UserManager<AppUser> userManager, IAppUserRepository appUserRepository, IPasswordHasher<AppUser> passwordHasher, SignInManager<AppUser> signInManager)
        {

            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
            this.passwordHasher = passwordHasher;
            this.signInManager = signInManager;
        }

        public IActionResult MyProfile()
        {

            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            return View(user);
        }

        public IActionResult ProfileSettings()
        {
            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            return PartialView("_ProfileSettings", user);
        }

        [HttpPost]
        public IActionResult ProfileSettings(AppUser user)
        {
            int userId = int.Parse(userManager.GetUserId(User));
            AppUser updatePerson = appUserRepository.GetById(userId);
            updatePerson.FirstName = user.FirstName;
            updatePerson.LastName = user.LastName;
            updatePerson.Email = user.Email;
            updatePerson.PhoneNumber = user.PhoneNumber;
            appUserRepository.Update(updatePerson);

            return PartialView("_ProfileSettings", user);
        }

        public IActionResult ChangePassword()
        {
            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            return PartialView("_ChangePassword", user);
        }

        [HttpPost]
        public IActionResult ChangePassword(string newPassword)
        {
            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            ChangePassword_VM changePassword_VM = new ChangePassword_VM()
            {
                Password = user.PasswordHash
            };
            
            user.PasswordHash = passwordHasher.HashPassword(user, newPassword);
            appUserRepository.Update(user);
            return PartialView("_ChangePassword", user);
        }



        public IActionResult Addresses()
        {

            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            return PartialView("_Addresses", user);
        }


    }
}
