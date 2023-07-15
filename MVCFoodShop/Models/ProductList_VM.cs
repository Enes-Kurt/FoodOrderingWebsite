using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Models
{
    public class ProductList_VM
    {
        public List<Category> Categories { get; set; }
        public SelectList CategoriesComboBox { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
