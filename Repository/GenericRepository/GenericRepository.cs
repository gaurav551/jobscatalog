using JobHub.Data;
using JobHub.Models;

namespace JobHub.GenericRepository
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
       
    }
}