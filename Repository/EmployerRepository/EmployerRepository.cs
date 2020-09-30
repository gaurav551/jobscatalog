using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApplicationData.Models.ViewModels;
using JobHub.Data;
using Microsoft.AspNetCore.Http;

namespace Repository
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly ApplicationDbContext context;
        public EmployerRepository(ApplicationDbContext context)
        {
            this.context = context;

        }

        public async Task CreateCompanyAsync(JobHub.Models.Company company, IFormFile file)
        {
             var fileName = company.CompanyName + company.Id + file.FileName;
             string folder = "companies";
             await GImageResizer.ResizeImage(file, fileName, folder);
            company.Logo = fileName;
           
            context.Companies.Add(company);
        }

        public async Task UpdatePhoto(int id, IFormFile file)
        {
            var company = context.Companies.FirstOrDefault(x => x.Id == id);
            var image = company.Logo;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/companies", image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            var fileName = company.CompanyName + id + file.FileName;
            //IFormFile, FileName, Dirextory inside wwwroot
            string folder = "companies";
            await GImageResizer.ResizeImage(file, fileName, folder);
            company.Logo = fileName;
            context.Companies.Update(company);
            context.SaveChanges();
        }

        IQueryable<ApplicantsView> IEmployerRepository.GetApplicants( string jobPosterUserId)
        {
            return (from a in context.AppliedJobs
                              join c in context.Jobs on a.JobId equals c.Id
                              select new ApplicantsView()
                              {
                                  JobPostedBy = c.PostedBy,
                                  JobTitle = context.Jobs.FirstOrDefault(p => p.Id == a.JobId).Title,
                                  ApplicantsName = context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(a.UserId)).Fullname,
                                  AppliedDate = a.AppliedDate,
                                  ApplicantsCity = context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(a.UserId)).City,
                                  ApplicantsTitle = context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(a.UserId)).ProfessionalTitle,
                                  MinSalaryAndMaxSalary = c.MinSalary.ToString() + "-" + c.MaxSalary.ToString(),
                                  JobTag = c.Tags
                                }).Where(p=>p.JobPostedBy.Equals(jobPosterUserId));
           
        }
    }
}