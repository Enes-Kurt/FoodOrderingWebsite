using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class ContactController : BaseController
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ContactController(IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
