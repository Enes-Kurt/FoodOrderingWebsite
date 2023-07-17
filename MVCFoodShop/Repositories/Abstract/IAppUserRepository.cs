using MVCFoodShop.Entities;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IAppUserRepository:IRepository<AppUser>
    {
        //public AppUser GetUserWithShoppingCart(int userId);
        public AppUser GetUserByMail(string mail);
    }
}
