
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using System.Linq.Expressions;

namespace MVCFoodShop.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly FoodShopDbContext dbContext;
        public GenericRepository(FoodShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool Add(T entity)
        {
            try
            {
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch 
            {
                return false;
            }
        }
        public bool Delete(T entity)
        {
            try
            {
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch 
            {
                return false;
            }
        }
        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }
        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().FirstOrDefault(expression);
        }
        public IEnumerable<T> GetWehere(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().Where(expression);
        }
        public bool Update(T entity)
        {
            try
            {
                dbContext.Set<T>().Update(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
