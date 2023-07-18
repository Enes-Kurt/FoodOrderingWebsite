using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;
using NuGet.Protocol;

namespace MVCFoodShop.Controllers
{
    public class ProfileController : BaseController
    {

        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IPasswordHasher<AppUser> passwordHasher;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ProfileController(UserManager<AppUser> userManager, IAppUserRepository appUserRepository, IPasswordHasher<AppUser> passwordHasher, SignInManager<AppUser> signInManager,IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository, userManager)
        {

            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
            this.passwordHasher = passwordHasher;
            this.signInManager = signInManager;
            this.shoppingCartRepository = shoppingCartRepository;

        }

        public IActionResult MyProfile()
        {
            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            List<ShoppingCart> shoppingCarts = shoppingCartRepository.GetAllIncludeAllDataById(userId);
            Profile_VM profile = new Profile_VM()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreationDate = user.CreationDate,
                ShoppingCarts = shoppingCarts,
            };

            return View(profile);
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
        public async Task<IActionResult> ChangePassword(string password, string updateNewPassword)
        {

            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);

            bool isPasswordCorrect = await userManager.CheckPasswordAsync(user, password);
            if (isPasswordCorrect)
            {
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, updateNewPassword);
                await userManager.UpdateAsync(user);
                return PartialView("_ChangePassword");
            }
            else
            {
                ViewBag.ErrorMessage = "Mevcut şifre yanlış!";
                return View("_ChangePassword");
            }

        }

        //[HttpPost]
        //public IActionResult ChangePassword(string newPassword)
        //{
        //    int userId = int.Parse(userManager.GetUserId(User));
        //    AppUser user = appUserRepository.GetById(userId);

        //    ChangePassword_VM changePassword_VM = new ChangePassword_VM()
        //    {
        //        Password = user.PasswordHash
        //    };

        //    user.PasswordHash = passwordHasher.HashPassword(user, newPassword);
        //    appUserRepository.Update(user);
        //    return PartialView("_ChangePassword", user);
        //}



        public IActionResult Addresses()
        {

            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            return PartialView("_Addresses", user);
        }

        [HttpPost]
        public IActionResult Addresses(AppUser appUser)
        {

            int userId = int.Parse(userManager.GetUserId(User));
            AppUser user = appUserRepository.GetById(userId);
            user.Address = appUser.Address;
            appUserRepository.Update(user);
            return PartialView("_Addresses", user);


        }
        public IActionResult PastOrderListElements(int id)
        {
            int userId = int.Parse(userManager.GetUserId(User));
            ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeAllData(id);
            return PartialView("_PastOrderElementListPartial", shoppingCart.ShoppingCartElements.ToList());
        }
    }
}
