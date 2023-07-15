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
        private readonly IMenuRepository menuRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper, IMenuRepository menuRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
            this.menuRepository = menuRepository;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                ViewBag.Role = "Admin";
            }
            else
            {
                ViewBag.Role = "User";
            }
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
            if (User.IsInRole("Admin"))
            {
                ViewBag.Role = "Admin";
            }
            else
            {
                ViewBag.Role = "User";
            }
            Category category = categoryRepository.GetFirstOrDefault(c => c.CategoryName == categoryName);
            ProductCards_VM pcVM = new ProductCards_VM();
            List<Product> products = new List<Product>();
            if (categoryName =="Menu")
            {
                pcVM.Menus = menuRepository.GetAllWithProducts().ToList();
            }
            else if (category == null)
            {
                pcVM.Menus = menuRepository.GetAllWithProducts().ToList();
                pcVM.Products = productRepository.GetAll().ToList();
            }
            else
            {
                pcVM.Products = productRepository.GetProductsSelectedCategory(category).ToList();
            }
            return PartialView("_ProductListPartial", pcVM);
        }
        [HttpPost]
        public IActionResult List(ProductList_VM pVM, List<int> selectedProducts)
        {
            if (selectedProducts == null)
            {
                Product product = mapper.Map<Product>(pVM);
                product.ProductIsActive = true;
                productRepository.Add(product);
            }
            else
            {
                Menu menu = mapper.Map<Menu>(pVM);
                foreach (var productId in selectedProducts)
                {
                    Product product = productRepository.GetById(productId);
                    menu.Products.Add(product);
                }
                menuRepository.Add(menu);
            }
            return RedirectToAction("Index");
        }



    }
}
