using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Menu> GetAllWithProducts()
        {
            return dbContext.Menus.Include(m => m.Products).Where(m=>m.MenuIsActive == true);
        }
    }
}
