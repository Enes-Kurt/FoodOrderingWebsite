
using Microsoft.AspNetCore.Identity;
using MVCFoodShop.Entities;
using System.Linq.Expressions;

namespace MVCFoodShop.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);

        T GetById(int id);
        IEnumerable<T> GetAll();

        //studentRepository.FirstOrDefault(a=>a.Id==id)
        //bu şekilde olcak bundan sonra 
        //studentRepository.GetFirstOrDefault(a=>a.Id==id)
        T GetFirstOrDefault(Expression<Func<T, bool>> expression);


        //studentRepository.studentRepository(a=>a.FirstName=="Ahmet")
        //bu şekilde olcak bundan sonra 
        //studentRepository.Where(a=>a.FirstName=="Ahmet")
        IEnumerable<T> GetWehere(Expression<Func<T, bool>> expression);
    }
}
