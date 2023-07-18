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

        public IEnumerable<Product> GetAllActiveProducts()
        {
            return dbContext.Products.Where(p=>p.ProductIsActive == true);
        }

        public IEnumerable<Product> GetProductsSelectedActiveCategory(Category category)
        {
            return dbContext.Products.Where(p => p.Category == category && p.ProductIsActive == true);
        }

        public IEnumerable<Product> GetSelectedProtuctsByCategory(string category)
        {
            return dbContext.Products.Where(p => p.Category.CategoryName == category && p.ProductIsActive == true);
        }

        public IEnumerable<Product> GetSelectedProtuctsByCategoryAndMenuID(Menu menu, string category)
        {
            return dbContext.Products.Where(p => p.Category.CategoryName == category && p.Menus.Contains(menu));
        }
    }
}
