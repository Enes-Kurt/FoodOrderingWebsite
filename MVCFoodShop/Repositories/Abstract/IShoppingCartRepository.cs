using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IShoppingCartRepository:IRepository<ShoppingCart>
    {
        public ShoppingCart GetShoppingCartIncludeElementsWithProducts(int id);
        public ShoppingCart GetShoppingCartIncludeElementsWithAllData(int id);
        public ShoppingCart GetShoppingCartIncludeAllData(int id);
        public List<ShoppingCart> GetAllIncludeAllDataById(int id);
        public ShoppingCart GetShoppingCartIncludeElements(int id);
        public AppUser GetUserIncludeShoppingCartById(int id);
    }
}
