﻿using Microsoft.AspNetCore.Identity;

namespace MVCFoodShop.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public AppUser()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
        }
        public string Address { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
