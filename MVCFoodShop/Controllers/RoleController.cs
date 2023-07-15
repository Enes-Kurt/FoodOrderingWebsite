using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVCFoodShop.Controllers
{
    [Authorize(Roles="Admin")]
    public class RoleController : Controller
    {
        public RoleController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
