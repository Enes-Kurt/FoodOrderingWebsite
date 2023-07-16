using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCFoodShop.Entities;
using System.Reflection.Emit;

namespace MVCFoodShop.Data
{
    public class FoodShopDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public FoodShopDbContext(DbContextOptions<FoodShopDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<ShoppingCartElement> ShoppingCartElements { get; set; }
        public DbSet<MenuCartElement> MenuCartElements { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<MenuCart> MenuCarts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppRole>().HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = 2, Name = "User", NormalizedName = "USER" },
                new AppRole { Id = 3, Name = "RegisteredUser", NormalizedName = "REGİSTEREDUSER" }
            );

            builder.ApplyConfigurationsFromAssembly(typeof(FoodShopDbContext).Assembly);
        }
    }
}