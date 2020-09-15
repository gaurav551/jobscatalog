using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models

{
    public class Company
    {
    public int Id { get; set; }
      [MaxLength(256)]
    public string CompanyName  { get; set; }
      [MaxLength(256)]
    public string EmployerEmail { get; set; }
      [MaxLength(256)]
    public string Website { get; set; }
    public DateTime FoundedDate { get; set; }
      [MaxLength(256)]
    public string Category { get; set; }
      [MaxLength(256)]
    public string Country { get; set; }
      [MaxLength(3000)]


    public string Description { get; set; }
      [MaxLength(256)]
    public string Phone { get; set; }
      [MaxLength(256)]
    public string Email { get; set; }
      [MaxLength(256)]
    public string City { get; set; }
      [MaxLength(256)]
    public string Address { get; set; }
      [MaxLength(256)]
    public string Logo { get; set; }
      [MaxLength(256)]
    public string UserId { get; set; }
    }

}