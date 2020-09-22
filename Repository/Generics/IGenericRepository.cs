using System;
using System.Linq.Expressions;

namespace Repository.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T t);
        void Update(T t);
        void Remove(Expression<Func<T, bool>> predicate);
         
    }
}