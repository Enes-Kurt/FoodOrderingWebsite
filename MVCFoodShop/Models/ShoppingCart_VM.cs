using MVCFoodShop.Entities;
using MVCFoodShop.Enums;

namespace MVCFoodShop.Models
{
    public class ShoppingCart_VM
    {
        public ShoppingCart_VM()
        {
            MenuCartsProductIDs = new int[1];
        }
        public int ProductOrMenuID { get; set; }
        public string TypeName { get; set; }
        public int ElementAmount { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int[] MenuCartsProductIDs { get; set; } 
        //public int[] MenusIDs { get; set; }
        public int MenuID { get; set; }
        public MenuType MenuType { get; set; }
        public string ShowShoppingChart { get; set; }
    }
}
