using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssueTracker.Models
{
    public class Comment : BaseEntity
    {
        public ApplicationUser User { get; set; }
        public string Text { get; set; }
        public DateTime? Posted { get; set; }
        public Guid IssueId { get; set; }
        public Issue Issue { get; set; }
    }
}