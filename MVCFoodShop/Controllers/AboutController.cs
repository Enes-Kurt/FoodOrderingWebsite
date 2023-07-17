using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class AboutController : BaseController
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public AboutController(IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
