using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Configuration
{
    public class Product_CFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { 
                    ID = 1, 
                    ProductName = "Cola", 
                    CategoryID = 2, 
                    ProductPrice = 30, 
                    ProductIsActive = true, 
                    ProductDeclaration= "A delightful flavor that dances with ice particles: Cola, the perfect choice for a refreshing break.", 
                    ProductCoverImage= "coca-cola.png"
                },
                new Product { 
                    ID = 2, 
                    ProductName = "Fanta", 
                    CategoryID = 2, 
                    ProductPrice = 30, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Fanta, with its sweet and fruity flavor, delights your taste buds and provides a refreshing beverage experience with every sip.",
                    ProductCoverImage = "fdb65e80-0777-443f-ad15-6045ef4f1a0c-fanta.png"
                },
                new Product { 
                    ID = 3, 
                    ProductName = "Ayran", 
                    CategoryID = 2, 
                    ProductPrice = 20, 
                    ProductIsActive = true , 
                    ProductDeclaration= "Ayran, the traditional Turkish delicacy, instantly refreshes and relaxes you with its cooling and invigorating taste.",
                    ProductCoverImage = "ayran-195-ml.png"
                },
                new Product { 
                    ID = 4, 
                    ProductName = "Köfte Burger", 
                    CategoryID = 1, 
                    ProductPrice = 80, 
                    ProductIsActive = true, 
                    ProductDeclaration = "A burger that combines delicious meatballs with fresh vegetables, cooked to perfection. With every bite, it delights the palate with rich meat flavors and exquisite spices. The perfect choice for an exceptional meatball burger experience!",
                    ProductCoverImage = "double-kofteburger-1.png"
                },
                new Product { 
                    ID = 5, 
                    ProductName = "Chicken Burger", 
                    CategoryID = 1, 
                    ProductPrice = 70, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Moist and tender chicken meat, combined with crispy breading, creates the unique taste of a chicken burger. It is a light and healthy choice that offers both delicious flavor and nutritional value. A favorite among chicken lovers!",
                    ProductCoverImage = "tavukburger.png"
                },
                new Product { 
                    ID = 6, 
                    ProductName = "Mayonnaise", 
                    CategoryID = 3, 
                    ProductPrice = 8, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Mayonnaise, with its creamy texture and slightly tangy taste, adds a distinct flavor to every bite. It is a must-have condiment for burgers.",
                    ProductCoverImage = "mini-mayonez.png"
                },
                new Product { 
                    ID = 7, 
                    ProductName = "Ketchup", 
                    CategoryID = 3, 
                    ProductPrice = 8, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Ketchup, a sweet, tangy, and slightly spicy flavor bomb, is one of the essential sauces for burgers.",
                    ProductCoverImage = "mini-ketcap.png"
                },
                new Product { 
                    ID = 8, 
                    ProductName = "Ranch Sauce", 
                    CategoryID = 3, 
                    ProductPrice = 10, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Ranch sauce, with its creamy consistency and refreshing flavor, adds a wonderful touch to burgers.",
                    ProductCoverImage = "mini-ranch.png"
                },
                new Product { 
                    ID = 9, 
                    ProductName = "Bufala Sauce", 
                    CategoryID = 3, 
                    ProductPrice = 10, 
                    ProductIsActive = true, 
                    ProductDeclaration = "Bufala sauce, a rich and spicy condiment, adds a mildly spicy and sweet flavor to burgers.",
                    ProductCoverImage = "mini-buffalo-1.png"
                },
                new Product
                {
                    ID = 10,
                    ProductName = "potatoes",
                    CategoryID = 1,
                    ProductPrice = 50,
                    ProductIsActive = true,
                    ProductDeclaration = "Crispy and delicious, golden fries offer a satisfying snack option. These thinly sliced and carefully fried potatoes provide a perfect taste experience when served as a side dish or enjoyed on their own. A favorite choice for potato lovers!",
                    ProductCoverImage = "potato.png"
                }

                );
        }
    }
}
