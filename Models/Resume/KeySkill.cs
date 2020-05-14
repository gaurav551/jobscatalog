using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class KeySkill
    {
        public int Id { get; set; }
          [MaxLength(2000)]
        public string Skills { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}
    }
}