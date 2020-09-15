using System.Linq;
using JobHub.Data;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;

        }

        public bool IsProfileGood(string userId)
        {
           if(context.EmployeeProfiles.Any(x=>x.UserId.Equals(userId)))
           {
               System.Console.WriteLine("TT");
               return true;
           }
           else
           {
               System.Console.WriteLine("FF");
               return false;
           }
        }
    }
}