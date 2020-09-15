using System.ComponentModel.DataAnnotations;
using JobHub.Models;
namespace JobHub.Models.Resume
{
    public class ProfileSummary
    {
        public int Id { get; set; }
          [MaxLength(3000)]
        public string Summary { get; set; }
        public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}
    }
}