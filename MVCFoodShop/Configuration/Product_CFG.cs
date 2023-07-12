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
                new Product { ID = 1, ProductName = "Kola", CategoryID = 2, Price = 30, IsActive = true},
                new Product { ID = 2, ProductName = "Fanta", CategoryID = 2, Price = 30, IsActive = true},
                new Product { ID = 3, ProductName = "Ayran", CategoryID = 2, Price = 20, IsActive = true}

                );
        }
    }
}
