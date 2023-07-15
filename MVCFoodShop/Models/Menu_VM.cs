using MVCFoodShop.Entities;

namespace MVCFoodShop.Models
{
    public class Menu_VM
    {
        public int ProductID { get; set; }
        public List<Product> MenuProducts { get; set; }
    }
}
