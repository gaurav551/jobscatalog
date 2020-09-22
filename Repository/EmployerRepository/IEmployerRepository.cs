using System.Linq;
using System.Threading.Tasks;
using ApplicationData.Models.ViewModels;
using JobHub.Models;
using Microsoft.AspNetCore.Http;

namespace Repository
{
    public interface IEmployerRepository
    {
        Task UpdatePhoto(int id, IFormFile file);
        IQueryable<ApplicantsView> GetApplicants(string jobPosterUserId);
        Task CreateCompanyAsync(Company company, IFormFile file);
        
    }
}