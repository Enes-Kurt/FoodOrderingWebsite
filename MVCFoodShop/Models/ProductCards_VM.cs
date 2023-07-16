using MVCFoodShop.Entities;

namespace MVCFoodShop.Models
{
    public class ProductCards_VM
    {
        public ProductCards_VM()
        {
            Products = new List<Product>();
            Menus = new List<Menu>();
        }
        public List<Product> Products { get; set; }
        public List<Menu> Menus { get; set; }
        public int ProductOrMenuID { get; set; }
        public string TypeName { get; set; }
        public int ShoppingCartElementAmount { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
