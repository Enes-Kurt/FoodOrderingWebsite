using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class ShoppingCartController : BaseController
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShoppingCartDetails()
        {
            return View();
        }
    }
}
