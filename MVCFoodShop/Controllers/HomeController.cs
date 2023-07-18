using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using System.Diagnostics;

namespace MVCFoodShop.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IMenuRepository menuRepository;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public HomeController(IMenuRepository menuRepository, IShoppingCartRepository shoppingCartRepository, UserManager<AppUser> userManager) : base(shoppingCartRepository, userManager)
        {
            this.menuRepository = menuRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            return View(menuRepository.GetByMenusNames("CampFire", "Smokey Deluxe", "Cheesy BBQ"));
        }

    }
}