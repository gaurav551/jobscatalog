using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class JobPreference
    {
        public int Id { get; set; }
          [MaxLength(256)]
        public string Industry { get; set; }
          [MaxLength(256)]
        public string FunctionalArea { get; set; }
          [MaxLength(256)]
        public string JobType { get; set; }
          [MaxLength(256)]
        public string DesiredLocation { get; set; }
        public int ExpectedSalary { get; set; }
        public int CurrentSalary { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}
    }
}