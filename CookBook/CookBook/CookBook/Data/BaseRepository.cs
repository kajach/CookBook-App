using CookBook.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CookBook.Data
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        private SQLiteAsyncConnection database;

        public BaseRepository(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
        }

        public async Task<List<T>> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null)
        {
            var query = database.Table<T>();

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = query.OrderBy<TValue>(orderBy);

            return await query.ToListAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await database.FindAsync<T>(predicate);
        }

        public async Task<T> GetById(int id)
        {
            return await database.FindAsync<T>(id);
        }

        public async Task<int> Insert(T item)
        {
            return await database.InsertAsync(item);
        }

        public async Task<int> Update(T item)
        {
            return await database.UpdateAsync(item);
        }

        public async Task<int> Delete(T item)
        {
            return await database.DeleteAsync(item);
        }
    }
}
