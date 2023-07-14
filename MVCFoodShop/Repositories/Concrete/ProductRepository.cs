using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly FoodShopDbContext dbContext;

        public ProductRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetProductsSelectedCategory(Category category)
        {
            return dbContext.Products.Where(p => p.Category == category);
        }
    }
}
