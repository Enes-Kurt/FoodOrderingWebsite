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

        public BaseController(IShoppingCartRepository shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var session = context.HttpContext.Session;


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
