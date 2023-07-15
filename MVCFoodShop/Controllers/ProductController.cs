using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MVCFoodShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        static List<Product> MenuProducts1 = new List<Product>();
        public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            ProductList_VM productList_VM = new ProductList_VM()
            {
                Products = productRepository.GetAll().ToList(),
                Categories = categoryRepository.GetAll().ToList(),
                CategoriesComboBox = new SelectList(categoryRepository.GetAll().ToList(), "ID", "CategoryName")
            };
            return View(productList_VM);
        }

        public IActionResult List(string categoryName)
        {
            Category category = categoryRepository.GetFirstOrDefault(c => c.CategoryName == categoryName);
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
        [HttpPost]
        public IActionResult List(ProductList_VM pVM)
        {
            Product product = mapper.Map<Product>(pVM);
            product.ProductIsActive = true;
            productRepository.Add(product); 
            return RedirectToAction("Index");
        }
        public IActionResult MenuProducts(int id)
        {
            Product product = productRepository.GetById(id);
            
            return PartialView("_MenuProductList", MenuProducts1);
        }



    }
}
