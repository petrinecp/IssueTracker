using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}