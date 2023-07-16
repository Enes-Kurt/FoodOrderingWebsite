using Microsoft.AspNetCore.Identity;

namespace MVCFoodShop.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public AppUser()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string? NewPassword { get; set; }
        public string? CoverImage { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }


    }
}
