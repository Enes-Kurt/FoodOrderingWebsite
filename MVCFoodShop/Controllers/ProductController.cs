using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }


        public IActionResult Index()
        {
            return View(categoryRepository.GetAll().ToList());
        }

        public IActionResult List(string categoryName)
        {
            Category category = categoryRepository.GetFirstOrDefault(c=>c.CategoryName == categoryName);
            List<Product> products = new List<Product>();
            if (category == null)
            {
                products = productRepository.GetAll().ToList();
            }
            else
            {
                products = productRepository.GetProductsSelectedCategory(category).ToList();
            }
            return PartialView("_ProductListPartial", products);
        }

    }
}
