using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Models
{
    public class ProductList_VM
    {
        public ProductList_VM()
        {
            MenuProducts = new List<Product>();
        }
        public List<Product> Products { get; set; }
        public List<Product> MenuProducts { get; set; }
        public List<Category> Categories { get; set; }
        public SelectList CategoriesComboBox { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }
        public int FoodCount { get; set; }
        public int BeverageCount { get; set; }
        public int SauceCount { get; set; }
        public int ProductID { get; set; }
    }
}
