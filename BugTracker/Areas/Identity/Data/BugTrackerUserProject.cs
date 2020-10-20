using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Areas.Identity.Data
{
    public class BugTrackerUserProject
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string BugTrackerUserId { get; set; }
        public BugTrackerUser BugTrackerUser { get; set; }
    }
}
