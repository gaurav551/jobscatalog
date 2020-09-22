using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobHub.Data;
using JobHub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;

        }

        

        public EmployeeProfile GetEmployeeProfile(string userId)
        {
            return context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(userId));
        }

        public bool IsProfileGood(string userId)
        {
           if(context.EmployeeProfiles.Any(x=>x.UserId.Equals(userId)))
           {
               System.Console.WriteLine("TT");
               return true;
           }
           else
           {
               System.Console.WriteLine("FF");
               return false;
           }
        }

        public async Task UpdatePhoto(int id, IFormFile file)
        {
            var employee = context.EmployeeProfiles.FirstOrDefault(x => x.Id == id);
            var image = employee.PhotoUrl;
            if (image != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/employee", image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            string folder = "employee";
            var fileName = employee.Fullname + id + file.FileName;
            await GImageResizer.ResizeImage(file, fileName, folder);
            employee.PhotoUrl = fileName;
            context.EmployeeProfiles.Update(employee);
           
        }
        public void CreateProfile(EmployeeProfile e)
        {
           context.EmployeeProfiles.Add(e);
           
        }

        public void UpdateProfile(EmployeeProfile e)
        {
            var emp = context.EmployeeProfiles.AsNoTracking().FirstOrDefault(x=>x.Id==e.Id);
            e.PhotoUrl = emp.PhotoUrl;
            e.UserId = emp.UserId;
            context.EmployeeProfiles.Update(e);
           
        }
    }
}