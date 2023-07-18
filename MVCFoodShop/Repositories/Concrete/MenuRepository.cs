using Microsoft.EntityFrameworkCore;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
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

        public List<Menu> GetByMenusNames(params string[] menuNames)
        {
            List<Menu> menuList = new List<Menu>();   
            foreach (var menuName in menuNames)
            {
                Menu menu = dbContext.Menus.Where(x => x.MenuName == menuName).FirstOrDefault();
                menuList.Add(menu);
            }
           return menuList;
        }
        public Menu GetByMenuIncludeProductsById(int menuId)
        {
            return dbContext.Menus.Include(m => m.Products).FirstOrDefault(m=>m.ID  == menuId);
        }
    }
}
