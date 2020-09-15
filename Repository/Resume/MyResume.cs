using System.Linq;
using JobHub.Data;
using JobHub.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MyResumeRepository : IMyResumeRepository
    {
        private readonly ApplicationDbContext context;
        public MyResumeRepository(ApplicationDbContext context)
        {
            this.context = context;

        }
        public async System.Threading.Tasks.Task<MyResumeView> GetMyResumeAsync(string userId)
        {
            var employee = await context.EmployeeProfiles.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            var view = new MyResumeView();
            view.Id = employee.Id;
            view.Name = employee.Fullname;
            view.Address = employee.Address;
            view.City = employee.City;
            view.ProfessionalTitle = employee.ProfessionalTitle;
            view.Email = employee.Email;
            view.Phone = employee.Phone;
            view.PhotoUrl = employee.PhotoUrl;
            view.Objective = context.Objectives.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.KeySkill = context.KeySkills.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Experience = context.Experiences.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Education = context.Educations.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Specialization = context.Specializations.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.ProfileSummary = context.ProfileSummarys.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.JobPreference = context.JobPreferences.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            return view;

        }
    }
}