using System.Threading.Tasks;
using JobHub.Models;
using Microsoft.AspNetCore.Http;

namespace Repository
{
    public interface IEmployeeRepository
    {
       bool IsProfileGood(string userId);
       EmployeeProfile GetEmployeeProfile(string userId);
       Task UpdatePhoto(int id, IFormFile file);
       void CreateProfile(EmployeeProfile e);
       void UpdateProfile(EmployeeProfile e);
         
    }
}