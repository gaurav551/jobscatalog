using System.Linq;
using System.Threading.Tasks;
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

        public MyCvView GetMyCV(string userId)
        {
            var employee =  context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(userId));
            var view = new MyCvView();
            view.Id = employee.Id;
            view.Name = employee.Fullname;
            view.Email = employee.Email;
            view.PhotoUrl = employee.Phone;
            view.Address = employee.Address;
            view.Specialization = context.Specializations.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id);
            view.ProfessionalTitle = employee.ProfessionalTitle;
            view.Education = context.Educations.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id);
            view.Objective = context.Objectives.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id).Title;
            view.KeySkill = context.KeySkills.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id).Skills;
            view.ProfileSummary = context.ProfileSummarys.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id);
            view.JobPreference = context.JobPreferences.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id);
             view.Experience = context.Experiences.FirstOrDefault(x=>x.EmployeeProfileId==employee.Id);
            return view;
        }

        public void SetEducation(MyResumeView v)
        {
            var ob = v.Education;
            var check = context.Educations.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.Educations.Add(ob);
            }
            else
            {
                context.Educations.Update(ob);

            }
        }

        public void SetExperience(MyResumeView v)
        {
            var ob = v.Experience;
            var check = context.Experiences.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.Experiences.Add(ob);
            }
            else
            {
                context.Experiences.Update(ob);
            }
        }

        public void SetJobPreference(MyResumeView v)
        {
            var ob = v.JobPreference;
            var check = context.JobPreferences.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.JobPreferences.Add(ob);
            }
            else
            {
                context.JobPreferences.Update(ob);
            }
        }

        public void SetKeySkill(MyResumeView v)
        {
            var ob = v.KeySkill;
            var check = context.KeySkills.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.KeySkills.Add(ob);
            }
            else
            {
                context.KeySkills.Update(ob);

            }
            context.SaveChanges();
        }

        public void SetProfileSummary(MyResumeView v)
        {
             var ob = v.ProfileSummary;
            var check = context.ProfileSummarys.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.ProfileSummarys.Add(ob);
            }
            else
            {
                context.ProfileSummarys.Update(ob);
            }
        }

        public void SetResumeObjective(MyResumeView v)
        {
           var ob = v.Objective;

            var check = context.Objectives.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
               
                  context.Objectives.Add(ob);
                  context.SaveChanges();
            }
            else
            {
                context.Objectives.Update(ob);
                  context.SaveChanges();
            }
          
        }

        public void SetSpecialization(MyResumeView v)
        {
            var ob = v.Specialization;
            var check = context.Specializations.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                context.Specializations.Add(ob);
            }
            else
            {
                context.Specializations.Update(ob);
            }
        }

        
    }
}