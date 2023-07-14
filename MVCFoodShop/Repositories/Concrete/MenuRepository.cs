using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class MenuRepository : GenericRepository<Menu>,IMenuRepository
    {
        private readonly FoodShopDbContext dbContext;

        public MenuRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
