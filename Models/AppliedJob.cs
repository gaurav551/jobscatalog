using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models
{
    public class AppliedJob
    {
        public int Id { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }
          [MaxLength(256)]
        public string UserId { get; set; }
        public DateTime AppliedData {get;set;} = DateTime.Now;
    }
}