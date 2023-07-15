using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> GetAllActiveCategories();
    }
}
