using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApplicationData.Models;
using ApplicationData.Models.ViewModels;
using Dapper;
using JobHub.Data;
using JobHub.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Repository.Generics;

namespace Repository
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        private readonly IConfiguration configuration;
        private readonly ApplicationDbContext context;

        public JobRepository(ApplicationDbContext context, IConfiguration configuration) : base(context)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public void Apply(int jobId, string userId)
        {
            var jobPostedBy = context.Jobs.FirstOrDefault(x => x.Id == jobId).PostedBy;
            var job = new AppliedJob { JobId = jobId, UserId = userId, JobPostedBy = jobPostedBy };
            context.AppliedJobs.Add(job);

        }

        public IQueryable<Job> GetBy(Expression<Func<Job, bool>> predicate)
        {

            return context.Set<Job>().Where(predicate);


        }



        public async Task<JobDetailsView> GetJobDetailsAsync(string userId, int jobId)
        {
            JobDetailsView v = new JobDetailsView();
            var job = context.Jobs.FirstOrDefault(x => x.Id == jobId);
            v.Job = job;
            v.TimeLeftForDeadline = TimeForDeadLine(job.Deadline);
            var company = context.Companies.FirstOrDefault(x => x.UserId.Equals(job.PostedBy));
            v.Logo = company.Logo;
            v.CompanyId = company.Id;
            v.IsExpired = DateTime.Now > job.Deadline ? true : false;
            v.Tags = job.Tags.Split(',').ToList();
            v.CompanyName = company.CompanyName;
            v.CompanyFounded = company.FoundedDate;
            v.IsApplied = context.AppliedJobs.Any(x => x.UserId.Equals(userId) && x.JobId == jobId);
            v.AppliedDate = DateTime.Now;
            v.IsSaved = context.Saves.Any(x => x.UserId.Equals(userId) && x.JobId == jobId);
            v.ViewCount = await AddAndGetCount(jobId);
            return v;
        }

        public IQueryable<SavedJobView> GetSavedJob(string userId, int count)

        {
            var savedjob = (from s in context.Saves
                            join j in context.Jobs on s.JobId equals j.Id
                            select new SavedJobView()
                            {
                                JobId = j.Id,
                                JobTitle = j.Title,
                                SavedOn = s.SavedOn,
                                UserId = s.UserId

                            }).Where(x => x.UserId.Equals(userId));
            return savedjob.Take(count);
        }

        public string SaveJob(int jobId, string userId)
        {
            if (context.Saves.Any(x => x.JobId == jobId && x.UserId.Equals(userId)))
            {
                var saved = context.Saves.FirstOrDefault(x => x.JobId == jobId && x.UserId.Equals(userId));
                context.Saves.Remove(saved);
                return "Job Removed from saved jobs";
            }
            else
            {
                var save = new Save { JobId = jobId, UserId = userId };
                context.Saves.Add(save);
                return "Job added to saved jobs";
            }

        }
        public IQueryable<IndexView> BrowseJob()
        {
            return (from j in context.Jobs
                    join c in context.Companies on j.PostedBy equals c.UserId
                    select new IndexView
                    {
                        Id = j.Id,
                        Title = j.Title,
                        Location = j.Location,
                        Type = j.Type,
                        Tag = j.Tags,
                        TimePosted = j.PostedOn,

                        Category = j.Category,
                        PostedOn = TimeAgo(j.PostedOn),
                        MinSalary = j.MinSalary,
                        MaxSalary = j.MaxSalary,
                        Image = c.Logo


                    });
        }
        public IQueryable<IndexView> BrowseJobOnly()
        {
            return (from j in context.Jobs
                    select new IndexView
                    {
                        Id = j.Id,
                        Title = j.Title,
                        Location = j.Location,
                        Type = j.Type,
                        Tag = j.Tags,
                        TimePosted = j.PostedOn,

                        Category = j.Category,
                        PostedOn = TimeAgo(j.PostedOn),
                        MinSalary = j.MinSalary,
                        MaxSalary = j.MaxSalary,



                    });


        }
        public List<string> GetPopularTags()
        {

            List<string> tagsList = new List<string>();
            var sql = "SELECT top 100 tags FROM jobs order by PostedOn desc";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Query<string>(sql);
                // var result = context.Jobs.OrderByDescending(x=>x.PostedOn).Select(x=>x.Tags).Take(100).ToArray();

                foreach (var x in result)
                {

                    foreach (var tags in x.Split(','))
                    {
                        tagsList.Add(tags);
                    }
                }


            }
            return tagsList.Distinct().ToList();
        }

        public List<string> GetSimilarTags(string tag)
        {
            List<string> tagsList = new List<string>();
            var sql = "SELECT top 100 tags FROM jobs WHERE tags like @Tag order by PostedOn desc ";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Query<string>(sql, new { Tag = $"%{tag}%" });
                // var result = context.Jobs.OrderByDescending(x=>x.PostedOn).Where(x=>x.Tags.Contains(tag)).Select(x=>x.Tags).Take(200).ToArray();
                foreach (var item in result)
                {
                    foreach (var tags in item.Split(',').ToArray().Take(4))
                    {

                        tagsList.Add(tags);
                    }


                }
            }
            return tagsList.Distinct().ToList();
        }



        #region 
        //Methods outside of Interface
        public async Task<int> AddAndGetCount(int jobId)
        {

            if (!context.JobViewCounts.Any(x => x.JobId == jobId))
            {
                JobViewCount viewCount = new JobViewCount();

                viewCount.Count = 1;
                viewCount.JobId = jobId;
                context.JobViewCounts.Add(viewCount);

            }
            else
            {
                var job = context.JobViewCounts.FirstOrDefault(x => x.JobId == jobId);
                job.Count += 1;
                context.JobViewCounts.Update(job);

            }
            await context.SaveChangesAsync();
            return context.JobViewCounts.FirstOrDefault(x => x.JobId == jobId).Count;


        }
        public static string TimeAgo(DateTime theDate)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - theDate.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";

            if (delta < 2 * MINUTE)
                return "a minute ago";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes ago";

            if (delta < 90 * MINUTE)
                return "an hour ago";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours ago";

            if (delta < 48 * HOUR)
                return "yesterday";

            if (delta < 30 * DAY)
                return ts.Days + " days ago";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "one year ago" : years + " years ago";
            }

        }
        public static string TimeForDeadLine(DateTime dt)
        {
            var time = dt.Subtract(DateTime.Now).TotalDays;
            var days = Math.Round(time, 0);

            return string.Format("apply before {0} days from now", days);
        }

        #endregion


    }
}