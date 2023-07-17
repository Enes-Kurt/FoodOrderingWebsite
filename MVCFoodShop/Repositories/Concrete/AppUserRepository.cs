using Microsoft.EntityFrameworkCore;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        private readonly FoodShopDbContext dbContext;
        public AppUserRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public AppUser GetUserByMail(string mail)
        {
            return dbContext.AppUsers.Include(a=>a.ShoppingCarts).FirstOrDefault(u => u.UserName == mail);
        }

        //public AppUser GetUserWithShoppingCart(int userId)
        //{
        //    return dbContext.AppUsers.Include("ShoppingCart.ShoppingCartElement.Product").FirstOrDefault(x=>x.Id==userId);
        //}
    }
}
