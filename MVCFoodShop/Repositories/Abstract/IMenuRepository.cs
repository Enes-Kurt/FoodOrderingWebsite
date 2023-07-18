using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IMenuRepository:IRepository<Menu>
    {
        public IEnumerable<Menu> GetAllWithProducts();

        public List<Menu> GetByMenusNames(params string[] menuNames);
        public Menu GetByMenuIncludeProductsById(int menuId);
    }
}
