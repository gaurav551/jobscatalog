using System.Threading.Tasks;
using JobHub.Models;

namespace Repository
{
    public interface IMyResumeRepository
    {
         Task<MyResumeView> GetMyResumeAsync(string userId);
          void  SetResumeObjective(MyResumeView v);
         void SetKeySkill(MyResumeView v);
         void SetEducation(MyResumeView v);
          void SetExperience(MyResumeView v);
          void SetSpecialization(MyResumeView v);
          void SetProfileSummary(MyResumeView v);
          void SetJobPreference(MyResumeView v);
          MyCvView GetMyCV(string userId);

    }
}