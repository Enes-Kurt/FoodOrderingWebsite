using MVCFoodShop.Entities;

namespace MVCFoodShop.Models
{
    public class Profile_VM
    {
        public Profile_VM()
        {
            ShoppingCarts = new List<ShoppingCart>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<ShoppingCart>? ShoppingCarts { get; set; }
    }
}
