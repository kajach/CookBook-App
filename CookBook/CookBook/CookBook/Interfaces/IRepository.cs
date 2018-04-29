using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CookBook.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<T> GetById(int id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
