using BugTracker.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<BugTrackerUser> Users { get; set; } = new List<BugTrackerUser>();
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
