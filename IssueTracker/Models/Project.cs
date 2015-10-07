using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssueTracker.Models
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}