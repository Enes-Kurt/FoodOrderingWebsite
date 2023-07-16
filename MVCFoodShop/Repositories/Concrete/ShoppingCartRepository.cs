using Microsoft.EntityFrameworkCore;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly FoodShopDbContext dbContext;

        public ShoppingCartRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public ShoppingCart GetShoppingCartIncludeElements(int id)
        {
            return dbContext.ShoppingCarts.Include(s => s.ShoppingCartElements).FirstOrDefault(s=>s.ID == id);
        }
    }
}
