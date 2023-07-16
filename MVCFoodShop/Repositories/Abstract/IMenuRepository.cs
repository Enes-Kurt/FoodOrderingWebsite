using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IMenuRepository:IRepository<Menu>
    {
        public IEnumerable<Menu> GetAllWithProducts();


    }
}
