using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApplicationData.Models;
using ApplicationData.Models.ViewModels;
using JobHub.Data;
using JobHub.Models;

namespace Repository
{
    public class JobRepository :  IJobRepository
    {
        private readonly ApplicationDbContext context;

        public JobRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Apply(int jobId, string userId)
        {
            var jobPostedBy = context.Jobs.FirstOrDefault(x=>x.Id==jobId).PostedBy;
            var job = new AppliedJob { JobId = jobId, UserId = userId, JobPostedBy = jobPostedBy };
            context.AppliedJobs.Add(job);
            
        }

        public List<Job> GetBy(Expression<Func<Job, bool>> predicate)
        {
        
            return context.Set<Job>().Where(predicate).Take(100).ToList();
        

        }

        

        public async Task<JobDetailsView> GetJobDetailsAsync(string userId, int jobId)
        {
            JobDetailsView v = new JobDetailsView();
             var job = context.Jobs.FirstOrDefault(x=>x.Id==jobId);
             v.Job = job;
            v.TimeLeftForDeadline = TimeForDeadLine(job.Deadline);
            var company = context.Companies.FirstOrDefault(x=>x.UserId.Equals(job.PostedBy));
            v.Logo = company.Logo;
            v.IsExpired = DateTime.Now>job.Deadline? true: false;
            v.Tags = job.Tags.Split(',').ToList();
            v.CompanyName =  company.CompanyName;
            v.CompanyFounded = company.FoundedDate;
            v.IsApplied = context.AppliedJobs.Any(x => x.UserId.Equals(userId) && x.JobId == jobId);
            v.IsSaved = context.Saves.Any(x => x.UserId.Equals(userId) && x.JobId == jobId);
            v.ViewCount = await AddAndGetCount(jobId);
            return v;
        }

        public List<SavedJobView> GetSavedJob(string userId, int start, int end)

        {
             var savedjob = (from s  in context.Saves
            join j in context.Jobs on s.JobId equals j.Id
            select new SavedJobView()
            {
                  JobId = j.Id,
                  JobTitle = j.Title,
                  SavedOn = s.SavedOn,
                   UserId = s.UserId

            });
            return savedjob.ToList();
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
        public IQueryable<IndexView> BrowseJob()
        {
           return from j in context.Jobs join c in context.Companies on j.PostedBy equals c.UserId
            select new IndexView{
              Id = j.Id,
              Title = j.Title,
              Location = j.Location,
              Type = j.Type,
              Tag = j.Tags,
             
              Category = j.Category,
              PostedOn= TimeAgo(j.PostedOn),
              MinSalary = j.MinSalary,
              MaxSalary = j.MaxSalary,
              Image = c.Logo
              

            } ;
        }

        #region 
        //Methods outside of Interface
        public async Task<int> AddAndGetCount(int jobId)
        {
          
            if(!context.JobViewCounts.Any(x=>x.JobId==jobId))
            {
                JobViewCount viewCount = new JobViewCount();
                
                viewCount.Count = 1;
                viewCount.JobId = jobId;
                context.JobViewCounts.Add(viewCount);

            }
            else
            {
            var job = context.JobViewCounts.FirstOrDefault(x=>x.JobId==jobId);
            job.Count +=1;
            context.JobViewCounts.Update(job);
            
            }
            await context.SaveChangesAsync();
            return context.JobViewCounts.FirstOrDefault(x=>x.JobId==jobId).Count;
           

        }
        public static string TimeAgo(DateTime theDate)
        {
            Dictionary<long, string> thresholds = new Dictionary<long, string>();
            int minute = 60;
            int hour = 60 * minute;
            int day = 24 * hour;
            thresholds.Add(60, "{0} seconds ago");
            thresholds.Add(minute * 2, "a minute ago");
            thresholds.Add(45 * minute, "{0} minutes ago");
            thresholds.Add(120 * minute, "an hour ago");
            thresholds.Add(day, "{0} hours ago");
            thresholds.Add(day * 2, "yesterday");
            thresholds.Add(day * 30, "{0} days ago");
            thresholds.Add(day * 365, "{0} months ago");
            thresholds.Add(long.MaxValue, "{0} years ago");
            long since = (DateTime.Now.Ticks - theDate.Ticks) / 10000000;
            foreach (long threshold in thresholds.Keys)
            {
                if (since < threshold)
                {
                    TimeSpan t = new TimeSpan((DateTime.Now.Ticks - theDate.Ticks));
                    return string.Format(thresholds[threshold], (t.Days > 365 ? t.Days / 365 : (t.Days > 0 ? t.Days : (t.Hours > 0 ? t.Hours : (t.Minutes > 0 ? t.Minutes : (t.Seconds > 0 ? t.Seconds : 0))))).ToString());
                }
            }
            return "";
        }
        public static string TimeForDeadLine(DateTime dt)
        {
            var time = dt.Subtract(DateTime.Now).TotalDays;
            var days = Math.Round(time,0);
            
            return string.Format("apply before {0} days from now",days);
        }


        

        #endregion


    }
}