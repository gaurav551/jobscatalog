using System.Threading.Tasks;
using JobHub.Models;

namespace Repository
{
    public interface IMyResumeRepository
    {
         Task<MyResumeView> GetMyResumeAsync(string userId);
    }
}