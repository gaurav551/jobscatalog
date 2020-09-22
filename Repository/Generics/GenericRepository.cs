using System;
using System.Linq;
using System.Linq.Expressions;
using JobHub.Data;

namespace Repository.Generics
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;

        }

        public void Create(T t)
        {
            context.Set<T>().Add(t);
        }

        public void Remove(Expression<Func<T, bool>> predicate)
        {
            var data = context.Set<T>().FirstOrDefault(predicate);
            context.Set<T>().Remove(data);
        }

        public void Update(T t)
        {
           context.Set<T>().Update(t);
        }
    }
}