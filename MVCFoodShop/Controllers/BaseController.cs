using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;

namespace MVCFoodShop.Controllers
{
    public class BaseController : Controller
    {
        protected IShoppingCartRepository shoppingCartRepository;
        private readonly UserManager<AppUser> userManager;

        public BaseController(IShoppingCartRepository shoppingCartRepository, UserManager<AppUser> userManager)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.userManager = userManager;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var session = context.HttpContext.Session;
            if(User.IsInRole("Admin"))
            {
                ViewBag.UserName = "Admin";

            }
            if (User.IsInRole("User"))
            {

                int userId = int.Parse(userManager.GetUserId(User));
                AppUser appUser = shoppingCartRepository.GetUserIncludeShoppingCartById(userId);
                ViewBag.UserName = appUser.FirstName+ " " + appUser.LastName;
                if (appUser.ShoppingCarts.Count != 0)
                {
                    ShoppingCart lasShoppingCart = appUser.ShoppingCarts.Last();
                    if (!lasShoppingCart.ShoppingCartIsActive)
                    {
                        ShoppingCart shoppingCart = new ShoppingCart()
                        {
                            AppUserID = 1,
                            ShoppingCartIsActive = true,
                            ShoppingCartPrice = 0,
                        };
                        shoppingCartRepository.Add(shoppingCart);

                        HttpContext.Session.SetString("ShoppingCartID", shoppingCart.ID.ToString());
                        HttpContext.Session.SetString("ShoppingCartProductCount", "0");
                    }
                    else
                    {
                        HttpContext.Session.SetString("ShoppingCartID", lasShoppingCart.ID.ToString());
                    }
                }
                else
                {
                    ShoppingCart shoppingCart = new ShoppingCart()
                    {
                        AppUserID = 1,
                        ShoppingCartIsActive = true,
                        ShoppingCartPrice = 0,
                    };
                    shoppingCartRepository.Add(shoppingCart);

                    HttpContext.Session.SetString("ShoppingCartID", shoppingCart.ID.ToString());
                    HttpContext.Session.SetString("ShoppingCartProductCount", "0");
                }
            }



            int scID = Convert.ToInt32(session.GetString("ShoppingCartID"));
            if (scID != 0)
            {

                ShoppingCart shoppingCart = shoppingCartRepository.GetShoppingCartIncludeElements(scID);
                if (shoppingCart.ShoppingCartElements != null)
                {
                    ViewBag.ProductCount = Convert.ToInt32(shoppingCart.ShoppingCartElements.Count);
                }
                else
                {
                    ViewBag.ProductCount = 0;
                }
            }
        }

        [HttpPost]
        public IActionResult SaveProductCount(int productCount)
        { 
            return NoContent();
        }
    }
}
