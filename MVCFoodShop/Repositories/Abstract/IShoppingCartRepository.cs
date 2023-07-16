using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IShoppingCartRepository:IRepository<ShoppingCart>
    {
        public ShoppingCart GetShoppingCartIncludeElements(int id);
    }
}
