using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Models
{
    public class Issue : BaseEntity
    {
        public string Name { get; set; }
        public Guid StateId { get; set; }
        public State State { get; set; }
        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}