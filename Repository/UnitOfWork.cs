using JobHub.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        
        public UnitOfWork(ApplicationDbContext context, IConfiguration configuration)
        {
            this.context = context;
            myResumeRepository = new MyResumeRepository(context);
            jobRepository = new JobRepository(context, configuration);
            employeeRepository = new EmployeeRepository(context);
            
            employerRepository = new EmployerRepository(context);

        }
        
        public IMyResumeRepository myResumeRepository { get; private set; }

        public IJobRepository jobRepository { get; private set; }
        

        public IEmployeeRepository employeeRepository {get; private set;}

        public IEmployerRepository employerRepository {get; private set;}

        public int Commit()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}