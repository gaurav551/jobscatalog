using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class Objective
    {
        public int Id { get; set; }
          [MaxLength(3000)]
        public string Title { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}
    }
}