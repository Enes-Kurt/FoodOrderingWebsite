using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Configuration
{
    public class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu { ID = 1, MenuName = "Whopper", Price = 180, IsActive = true},
                new Menu { ID = 2, MenuName = "Big King", Price = 170, IsActive = true},
                new Menu { ID = 3, MenuName = "King Chicken", Price = 160, IsActive = true },
                new Menu { ID = 4, MenuName = "Kids Menu", Price = 140, IsActive = true }
                );
        }
    }
}
