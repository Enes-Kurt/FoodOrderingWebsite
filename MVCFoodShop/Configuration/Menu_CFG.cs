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
                new Menu { ID = 1, MenuName = "Whopper", MenuPrice = 180, MenuIsActive = true},
                new Menu { ID = 2, MenuName = "Big King", MenuPrice = 170, MenuIsActive = true},
                new Menu { ID = 3, MenuName = "King Chicken", MenuPrice = 160, MenuIsActive = true },
                new Menu { ID = 4, MenuName = "Kids Menu", MenuPrice = 140, MenuIsActive = true }
                );
        }
    }
}
