using System;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IMyResumeRepository myResumeRepository {get;}
        IJobRepository jobRepository {get;}
        IEmployeeRepository employeeRepository{get;}
        IEmployerRepository employerRepository{get;}
        int Commit();
         
    }
}