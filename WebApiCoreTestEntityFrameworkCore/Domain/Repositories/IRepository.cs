using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public interface IRepository<T>
    {
        List<T> GetAllList();
        Task<List<T>> GetAllListAsync();
        List<T> GetAllList(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllListAsync(Expression<Func<T, bool>> predicate);
        T Get(int id);
        Task<T> GetAsync(int id);
        T Insert(T entity);
        Task<T> InsertAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}