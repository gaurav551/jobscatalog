using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApplicationData.Models.ViewModels;
using JobHub.Models;
using Repository.Generics;

namespace Repository
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        void Apply(int jobId, string userId);
        string SaveJob(int jobId, string userId);
        IQueryable<SavedJobView> GetSavedJob(string userId, int count);
        Task<JobDetailsView> GetJobDetailsAsync(string userId, int jobId);
        IQueryable<IndexView> BrowseJob();
       


      
        IQueryable<Job> GetBy(Expression<Func<Job, bool>> predicate);
        List<string> GetPopularTags();
        List<string> GetSimilarTags(string tag);
       

    }
}