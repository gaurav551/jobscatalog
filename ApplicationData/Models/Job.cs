using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models
{
    public class Job
    {
        public int Id { get; set; }
        [MaxLength(256)]
        public string PostedBy { get; set; }
        [Required]
          [MaxLength(256)]
        public string Title { get; set; }
         [Required]
           [MaxLength(256)]
        public string Email { get; set; }
         [Required]
           [MaxLength(512)]
        public string Tags { get; set; }
         [Required]
           [MaxLength(256)]
        public string Type { get; set; }
         [Required]
           [MaxLength(256)]
        public string Category { get; set; }
         
        public bool Status { get; set; } = false;
         [Required]
         [Range(1,900)]
        public int Opening { get; set; }
         [Required]
          [Range(0,100)]

        public int Experience { get; set; }
         [Required]
        
        public int MinSalary { get; set; }
         [Required]
          
        public int MaxSalary { get; set; }
         [Required]
         [MinLength(100)]
          [MaxLength(5000)]

        public string Description { get; set; }
         [Required]
          [MaxLength(256)]
        public string City { get; set; }
         [Required]
          [MaxLength(256)]
        public string Location { get; set; }
         [Required]
        public DateTime Deadline { get; set; }
         [Required]
          [MinLength(100)]
           [MaxLength(4000)]

        public string Requirement { get; set; }
         [Required]
        [MinLength(100)]
         [MaxLength(4000)]

        public string Responsibility { get; set; }
         [Required]
          [MinLength(100)]
            [MaxLength(4000)]

        public string  Benefits { get; set; }
        public DateTime PostedOn { get; set; } = DateTime.Now;
    }
}