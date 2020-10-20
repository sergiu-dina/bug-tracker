using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class ProjectTicketsViewModel
    {
        public Project Project { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
