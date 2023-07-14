using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class MenuCartElementRepository : GenericRepository<MenuCartElement>, IMenuCartElementRepository
    {
        private readonly FoodShopDbContext dbContext;

        public MenuCartElementRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
