using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using System.Linq.Expressions;

namespace MVCFoodShop.Repositories.Concrete
{
    public class ShoppingCartElementRepository : GenericRepository<ShoppingCartElement>, IShoppingCartElementRepository
    {
        private readonly FoodShopDbContext dbContext;

        public ShoppingCartElementRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        
    }
}
