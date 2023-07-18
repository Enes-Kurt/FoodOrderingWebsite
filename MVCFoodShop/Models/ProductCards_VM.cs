using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFoodShop.Entities;
using MVCFoodShop.Enums;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Models
{
    public class ProductCards_VM
    {
        private readonly IProductRepository productRepository;

        public ProductCards_VM(IProductRepository productRepository)
        {
            Products = new List<Product>();
            Menus = new List<Menu>();
            this.productRepository = productRepository;
        }
        public List<Product> Products { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Category> Categories { get; set; }
        public SelectList MenuTypes { get; set; }
        public List<Product> FindMenuListByCategory(Menu menu ,string category)
        {
            return productRepository.GetSelectedProtuctsByCategoryAndMenuID(menu, category).ToList();
        }
        public List<Product> GetProductsByCategory(string categoryName)
        {
            return productRepository.GetSelectedProtuctsByCategory(categoryName).ToList();
        }

      
    }
}
