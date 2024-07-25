using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity); // Add Update method
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
