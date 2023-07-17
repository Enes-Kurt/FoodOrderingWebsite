using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using System.Diagnostics;

namespace MVCFoodShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenuRepository menuRepository;

        public HomeController(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        public IActionResult Index()
        {
            return View(menuRepository.GetByMenusNames("Big King", "Whopper", "King Chicken"));
        }

    }
}