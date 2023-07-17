using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        public IEnumerable<Product> GetProductsSelectedActiveCategory(Category category);
        public IEnumerable<Product> GetAllActiveProducts();
        public IEnumerable<Product> GetSelectedProtuctsByCategoryAndMenuID(Menu menu, string category);
        public IEnumerable<Product> GetSelectedProtuctsByCategory( string category);
    }
}
