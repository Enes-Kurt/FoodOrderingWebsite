using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class AboutController : BaseController
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public AboutController(IShoppingCartRepository shoppingCartRepository,UserManager<AppUser> userManager) : base(shoppingCartRepository, userManager)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
