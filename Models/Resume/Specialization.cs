using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class Specialization
    {
        public int Id { get; set; }
          [MaxLength(256)]
        public string Specialization1 { get; set; }
          [MaxLength(256)]
         public string Specialization2 { get; set; }
           [MaxLength(256)]
          public string Specialization3 { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
         public int EmployeeProfileId {get;set;}
    }
}