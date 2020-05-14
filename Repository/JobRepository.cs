using System.Linq;
using JobHub.Data;
using JobHub.Models;

namespace JobHub.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationDbContext context;

        public JobRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Apply(int jobId, string userId)
        {
            var job = new AppliedJob { JobId = jobId, UserId = userId };
            context.AppliedJobs.Add(job);
            context.SaveChanges();
        }
         public void SaveJob(int jobId, string userId)
        {
            if(context.Saves.Any(x=>x.JobId==jobId && x.UserId.Equals(userId)))
            {
             var saved = context.Saves.FirstOrDefault(x=>x.JobId==jobId && x.UserId.Equals(userId));
             context.Remove(saved);
            }
            else
            {
            var save = new Save { JobId = jobId, UserId = userId };
            context.Saves.Add(save);
            }
            context.SaveChanges();
        }


    }
}