using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;

namespace MVCFoodShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShoppingCartDetails()
        {
            string shoppingCartIDSTR = HttpContext.Session.GetString("ShoppingCartID");
            int shoppingCartID = Convert.ToInt32(shoppingCartIDSTR);
            ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeAllData(shoppingCartID);
            return View(shoppingCart);
        }
    }
}
