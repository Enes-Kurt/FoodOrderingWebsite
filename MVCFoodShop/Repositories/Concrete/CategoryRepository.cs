
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly FoodShopDbContext dbContext;
        public CategoryRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Category> GetAllActiveCategories()
        {
            return dbContext.Categories.Where(c => c.CategoryIsActive == true).ToList();
        }
    }
}
