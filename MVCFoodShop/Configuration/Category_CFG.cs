using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Configuration
{
    public class Category_CFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { ID = 1, CategoryName = "Food", IsActive=true },
                new Category { ID = 2, CategoryName = "Beverage" , IsActive = true },
                new Category { ID = 3, CategoryName = "Sauce", IsActive = true }
                );
        }
    }
}
