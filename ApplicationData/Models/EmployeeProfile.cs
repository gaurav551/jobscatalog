using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models
{
    public class EmployeeProfile
    {
        public int Id { get; set; }
        [MaxLength(256)]
        public string UserId { get; set; }
         [MaxLength(256)]
        public string Fullname { get; set; }
         [MaxLength(2000)]
        public string ProfessionalTitle { get; set; }
          [MaxLength(256)]
        public string Language { get; set; }
        public int Age { get; set; }
          [MaxLength(20)]
        public string Gender { get; set; }
          [MaxLength(20)]
        public string MaritalStatus { get; set; }
          [MaxLength(2000)]
        public string About { get; set; }
          [MaxLength(256)]
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
          [MaxLength(256)]
        public string Country { get; set; }
          [MaxLength(256)]
        public string City { get; set; }
          [MaxLength(256)]
        public string ZipCode { get; set; }
          [MaxLength(256)]
        public string Address { get; set; }
          [MaxLength(256)]
        public string PhotoUrl {get;set;}
        public DateTime MemberSince { get; set; } = DateTime.Now;

    }
}