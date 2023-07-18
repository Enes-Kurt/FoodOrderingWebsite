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
        private readonly IShoppingCartElementRepository shoppingCartElementRepository;
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IShoppingCartElementRepository shoppingCartElementRepository, UserManager<AppUser> userManager, IAppUserRepository appUserRepository) : base(shoppingCartRepository, userManager)
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
        [HttpPost]
        public IActionResult ConfirmOrder()
        {
            
            int userId = int.Parse(userManager.GetUserId(User));
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeElements(scID);   
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

            return Ok();

        }

        public IActionResult ShoppingCartElementRemove(int id)
        {
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetById(scID);
            ShoppingCartElement shoppingCartElement = shoppingCartElementRepository.GetById(id);

            shoppingCart.ShoppingCartElements.Remove(shoppingCartElement);
            shoppingCart.ShoppingCartPrice = shoppingCart.ShoppingCartPrice - shoppingCartElement.ShoppingCartElementPrice;
            shoppingCartRepository.Update(shoppingCart);

            return RedirectToAction("ShoppingCartDetails");
        }

        public IActionResult AllShoppingCarElementRemove()
        {
            int scID = Convert.ToInt32(HttpContext.Session.GetString("ShoppingCartID"));
            ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeAllData(scID);
            shoppingCart.ShoppingCartPrice = Convert.ToDecimal(0.0);
            shoppingCart.ShoppingCartElements.Clear();

            shoppingCartRepository.Update(shoppingCart);

            return RedirectToAction("ShoppingCartDetails");
        }



    }
}
