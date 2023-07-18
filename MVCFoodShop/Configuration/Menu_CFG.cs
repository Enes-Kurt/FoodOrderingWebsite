using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Configuration
{
    public class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            //builder.HasData(
            //    new Menu
            //    {
            //        ID = 1,
            //        MenuName = "Whopper",
            //        MenuPrice = 180,
            //        MenuIsActive = true,
            //        FoodCount = 1,
            //        BeverageCount = 1,
            //        SauceCount = 2,
            //        MenuDeclaration = "Whopper Menu offers the king of flavors! A juicy and delicious beef patty, fresh vegetables, and mouthwatering sauces combined in one burger experience.",
            //        MenuCoverImage = "double-whopper-menu.png"
            //    },
            //    new Menu
            //    {
            //        ID = 2,
            //        MenuName = "Big King",
            //        MenuPrice = 170,
            //        MenuIsActive = true,
            //        FoodCount = 1,
            //        BeverageCount = 1,
            //        SauceCount = 2,
            //        MenuDeclaration = "Big King, a burger that's larger than life! Juicy beef patty, melted cheese, crispy bacon, and tangy special sauce come together in this epic burger indulgence.",
            //        MenuCoverImage = "big-king-menu.png"
            //    },
            //    new Menu
            //    {
            //        ID = 3,
            //        MenuName = "King Chicken",
            //        MenuPrice = 160,
            //        MenuIsActive = true,
            //        FoodCount = 1,
            //        BeverageCount = 1,
            //        SauceCount = 2,
            //        MenuDeclaration = "King Chicken, a royal treat for chicken lovers! Crispy, golden-brown chicken patty, fresh lettuce, and creamy mayo unite in a sandwich fit for a king.",
            //        MenuCoverImage = "bk-crispy-chicken-menu.png"
            //    },
            //    new Menu
            //    {
            //        ID = 4,
            //        MenuName = "Kids Menu",
            //        MenuPrice = 140,
            //        MenuIsActive = true,
            //        FoodCount = 1,
            //        BeverageCount = 1,
            //        SauceCount = 2,
            //        MenuDeclaration = "Kids Menu, a delightful feast for our little foodies! Mini burger, crispy fries, and a refreshing drink, specially crafted to satisfy their appetites and bring smiles to their faces.",
            //        MenuCoverImage = "kids-hamburger (1).png"
            //    }
            //    );
        }
    }
}

