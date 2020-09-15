using System;
using Microsoft.AspNetCore.Identity;

namespace JobHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsEmployer { get; set; }
    }
}