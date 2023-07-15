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
                new Category { ID = 1, CategoryName = "Food", CategoryIsActive = true },
                new Category { ID = 2, CategoryName = "Beverage" , CategoryIsActive = true },
                new Category { ID = 3, CategoryName = "Sauce", CategoryIsActive = true }
                );
        }
    }
}
