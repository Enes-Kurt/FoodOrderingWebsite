using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;

namespace MVCFoodShop.Controllers
{
    public class ShoppingCartController : BaseController
    {
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IShoppingCartElementRepository shoppingCartElementRepository;
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IShoppingCartElementRepository shoppingCartElementRepository, UserManager<AppUser> userManager, IAppUserRepository appUserRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.shoppingCartElementRepository = shoppingCartElementRepository;
            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
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

        public IActionResult ConfirmOrder()
        {
            int userId = int.Parse(userManager.GetUserId(User));
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetById(scID);
            shoppingCart.ShoppingCartIsActive = false;
            shoppingCartRepository.Update(shoppingCart);

            ShoppingCart newShoppingCart = new ShoppingCart()
            {
                AppUserID = userId,
                ShoppingCartIsActive = true,
                ShoppingCartPrice = 0,
            };
            shoppingCartRepository.Add(newShoppingCart);

            HttpContext.Session.SetString("ShoppingCartID", newShoppingCart.ID.ToString());

            return RedirectToAction("Index","Home");
        }

        public IActionResult ShoppingCartElementRemove(int id)
        {
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetById(scID);
            ShoppingCartElement shoppingCartElement = shoppingCartElementRepository.GetById(id);

            shoppingCart.ShoppingCartElements.Remove(shoppingCartElement);
            shoppingCartRepository.Update(shoppingCart);
            shoppingCartElementRepository.Update(shoppingCartElement);
            return RedirectToAction("ShoppingCartDetails");
        }

        public IActionResult AllShoppingCarElementRemove()
        {
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeAllData(scID);

            shoppingCart.ShoppingCartElements.Clear();

            shoppingCartRepository.Update(shoppingCart);

            return RedirectToAction("ShoppingCartDetails");
        }


    }
}
