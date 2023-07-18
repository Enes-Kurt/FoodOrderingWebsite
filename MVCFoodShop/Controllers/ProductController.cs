using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MVCFoodShop.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        private readonly IMenuRepository menuRepository;
        private readonly IShoppingCartElementRepository shoppingCartElementRepository;
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserRepository appUserRepository;
        private readonly IMenuCartRepository menuCartRepository;
        private readonly IMenuCartElementRepository menuCartElementRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper, IMenuRepository menuRepository, IShoppingCartElementRepository shoppingCartElementRepository, UserManager<AppUser> userManager, IAppUserRepository appUserRepository, IMenuCartRepository menuCartRepository, IMenuCartElementRepository menuCartElementRepository, IShoppingCartRepository shoppingCartRepository) : base(shoppingCartRepository, userManager)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
            this.menuRepository = menuRepository;
            this.shoppingCartRepository = shoppingCartRepository;
            this.shoppingCartElementRepository = shoppingCartElementRepository;
            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
            this.menuCartRepository = menuCartRepository;
            this.menuCartElementRepository = menuCartElementRepository;
        }

        public IActionResult Index(int shopCartId)
        {
            if (User.IsInRole("Admin"))
            {
                ViewBag.Role = "Admin";
            }
            else if (User.IsInRole("User"))
            {
                ViewBag.Role = "User";
            }
            else
            {
                ViewBag.Role = "";
            }
            ProductList_VM productList_VM = new ProductList_VM()
            {
                FoodList = productRepository.GetSelectedProtuctsByCategory("Food").ToList(),
                BeverageList = productRepository.GetSelectedProtuctsByCategory("Beverage").ToList(),
                SauceList = productRepository.GetSelectedProtuctsByCategory("Sauce").ToList(),
                Products = productRepository.GetAllActiveProducts().ToList(),
                Categories = categoryRepository.GetAllActiveCategories().ToList(),
                CategoriesComboBox = new SelectList(categoryRepository.GetAllActiveCategories().ToList(), "ID", "CategoryName")
            };
            return View(productList_VM);
        }

        public IActionResult List(string categoryName)
        {
            if (User.IsInRole("Admin"))
            {
                ViewBag.Role = "Admin";
            }
            else if (User.IsInRole("User"))
            {
                ViewBag.Role = "User";
            }
            else
            {
                ViewBag.Role = "";
            }
            Category category = categoryRepository.GetFirstOrDefault(c => c.CategoryName == categoryName);
            ProductCards_VM pcVM = new ProductCards_VM(productRepository);
            List<Product> products = new List<Product>();
            if (categoryName == "Menu")
            {
                pcVM.Menus = menuRepository.GetAllWithProducts().ToList();
            }
            else if (category == null)
            {
                pcVM.Menus = menuRepository.GetAllWithProducts().ToList();
                pcVM.Products = productRepository.GetAllActiveProducts().ToList();
            }
            else
            {
                pcVM.Products = productRepository.GetProductsSelectedActiveCategory(category).ToList();
            }
            return PartialView("_ProductListPartial", pcVM);
        }
        [HttpPost]
        public async Task<IActionResult> List(ProductList_VM pVM, List<int> selectedProducts, IFormFile ImageName)
        {
            if (selectedProducts.Count == 0)
            {
                Product product = mapper.Map<Product>(pVM);

                Guid guid = Guid.NewGuid();
                string newFileName = guid.ToString() + "_" + ImageName.FileName;
                product.ProductCoverImage = newFileName;

                FileStream fs = new FileStream("wwwroot/ProductImages/" + newFileName, FileMode.Create);

                await ImageName.CopyToAsync(fs);
                product.ProductIsActive = true;
                productRepository.Add(product);

            }
            else
            {
                Menu menu = mapper.Map<Menu>(pVM);

                Guid guid = Guid.NewGuid();
                string newFileName = guid.ToString() + "_" + ImageName.FileName;
                menu.MenuCoverImage = newFileName;

                FileStream fs = new FileStream("wwwroot/MenuImages/" + newFileName, FileMode.Create);
                await ImageName.CopyToAsync(fs);
                foreach (var productId in selectedProducts)
                {
                    Product product = productRepository.GetById(productId);
                    menu.Products.Add(product);
                }
                menu.MenuIsActive = true;
                menuRepository.Add(menu);
            }
            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult FillShoppingCart(ShoppingCart_VM scVM)
        {
            if ( User.IsInRole("User"))
            {


                string shoppingCartIDSTR = HttpContext.Session.GetString("ShoppingCartID");
                int shoppingCartID = Convert.ToInt32(shoppingCartIDSTR);
                ShoppingCart shoppingCart = shoppingCartRepository.GetById(shoppingCartID);
                if (scVM.ShowShoppingChart != "Show")
                {


                    int userıd = int.Parse(userManager.GetUserId(User));
                    AppUser user = appUserRepository.GetById(userıd);
                    shoppingCart.AppUserID = user.Id;
                    ShoppingCartElement shoppingCartElement = new ShoppingCartElement();
                    shoppingCartElement.ShoppingCartElementAmount = scVM.ElementAmount;
                    if (scVM.TypeName == "Menu")
                    {
                        Menu menu = menuRepository.GetById(scVM.MenuID);
                        MenuCart menuCart = new MenuCart()
                        {
                            MenuCartAmount = scVM.ElementAmount,
                            MenuType = scVM.MenuType,
                            MenuID = scVM.MenuID,
                            Menu = menu
                        };
                        menuCartRepository.Add(menuCart);
                        for (int i = 0; i < scVM.MenuCartsProductIDs.Length; i++)
                        {
                            MenuCartElement menuCartElement = new MenuCartElement()
                            {
                                MenuCartID = menuCart.ID,
                                ProductID = scVM.MenuCartsProductIDs[i],

                            };
                            menuCartElementRepository.Add(menuCartElement);
                            menuCart.MenuCartElements.Add(menuCartElement);
                        }
                        menuCartRepository.Update(menuCart);
                        MenuCart updatedMenuCart = menuCartRepository.GetById(menuCart.ID);

                        //shoppingCartElement.menu
                        shoppingCartElement.ShoppingCartElementPrice = menu.MenuPrice * scVM.ElementAmount;
                        shoppingCartElement.MenuCartID = updatedMenuCart.ID;
                        shoppingCartElement.MenuCart = updatedMenuCart;
                    }
                    else
                    {

                        shoppingCartElement.ProductID = scVM.ProductOrMenuID;
                        Product product = productRepository.GetById(scVM.ProductOrMenuID);
                        shoppingCartElement.Product = product;
                        shoppingCartElement.ShoppingCartElementPrice = shoppingCartElement.Product.ProductPrice * scVM.ElementAmount;
                    }
                    shoppingCartElement.ShoppingCart = shoppingCart;
                    shoppingCartElement.ShoppingCartID = shoppingCart.ID;
                    shoppingCartElementRepository.Add(shoppingCartElement);
                    shoppingCart.ShoppingCartElements.Add(shoppingCartElement);
                    shoppingCart.ShoppingCartPrice += shoppingCartElement.ShoppingCartElementPrice;
                    shoppingCartRepository.Update(shoppingCart);

                }
                ShoppingCart updatedShoppingCart = shoppingCartRepository.GetShoppingCartIncludeAllData(shoppingCart.ID);


                //updatedShoppingCart.ShoppingCartPrice = Convert.ToDecimal(0.0);
                //foreach (var scElement in updatedShoppingCart.ShoppingCartElements)
                //{
                //    updatedShoppingCart.ShoppingCartPrice += scElement.ShoppingCartElementPrice;
                //}
                //shoppingCartRepository.Update(updatedShoppingCart);
                scVM.ShoppingCart = updatedShoppingCart;
                return PartialView("_ShoppingCartPartial", scVM);
            }
            else
            {
                return NoContent();
            }

        }

    }
}
