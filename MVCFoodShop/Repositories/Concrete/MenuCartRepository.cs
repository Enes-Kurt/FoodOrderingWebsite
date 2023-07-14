using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class MenuCartRepository : GenericRepository<MenuCart>, IMenuCartRepository
    {
        private readonly FoodShopDbContext dbContext;

        public MenuCartRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
