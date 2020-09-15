using JobHub.Data;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            myResumeRepository = new MyResumeRepository(context);
            jobRepository = new JobRepository(context);
            employeeRepository = new EmployeeRepository(context);

        }
        public IMyResumeRepository myResumeRepository { get; private set; }

        public IJobRepository jobRepository { get; private set; }

        public IEmployeeRepository employeeRepository {get; private set;}

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