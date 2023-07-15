using Microsoft.AspNetCore.Identity;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Utilities
{
    public class ForLogin
    {
        public static async void AddSuperUserAsync(UserManager<AppUser> userMan)
        {
            AppUser user = new AppUser
            {
                UserName = "superUser@deneme.com",
                NormalizedUserName = "SUPERUSER@DENEME.COM",
                Email = "superUser@deneme.com",
                NormalizedEmail = "SUPERUSER@DENEME.COM",
                Address = "İstanbul",
                FirstName = "Admin",
                LastName = "Admin"
            };
            await userMan.CreateAsync(user, "uSer_123");
            await userMan.AddToRoleAsync(user, "Admin");
        }
    }
}
