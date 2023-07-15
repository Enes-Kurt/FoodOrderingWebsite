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
                new Product { ID = 1, ProductName = "Kola", CategoryID = 2, ProductPrice = 30, ProductIsActive = true},
                new Product { ID = 2, ProductName = "Fanta", CategoryID = 2, ProductPrice = 30, ProductIsActive = true},
                new Product { ID = 3, ProductName = "Ayran", CategoryID = 2, ProductPrice = 20, ProductIsActive = true},
                new Product { ID = 4, ProductName = "Köfte Burger", CategoryID = 1, ProductPrice = 20, ProductIsActive = true},
                new Product { ID = 5, ProductName = "Tavuk Burger", CategoryID = 1, ProductPrice = 20, ProductIsActive = true},
                new Product { ID = 6, ProductName = "Mayonez", CategoryID = 3, ProductPrice = 20, ProductIsActive = true}
                );
        }
    }
}
