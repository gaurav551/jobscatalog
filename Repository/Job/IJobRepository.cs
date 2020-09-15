using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApplicationData.Models.ViewModels;
using JobHub.Models;

namespace Repository
{
    public interface IJobRepository
    {
        void Apply(int jobId, string userId);
        void SaveJob(int jobId, string userId);
        List<SavedJobView> GetSavedJob(string userId, int start, int end);
        Task<JobDetailsView> GetJobDetailsAsync(string userId, int jobId);
        IQueryable<IndexView> BrowseJob();

      
        List<Job> GetBy(Expression<Func<Job, bool>> predicate);
       

    }
}