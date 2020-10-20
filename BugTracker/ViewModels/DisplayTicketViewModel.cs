using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class DisplayTicketViewModel
    {
        public Ticket Ticket { get; set; }
        public Project Project { get; set; }
        public bool FromTickets { get; set; } = false;
    }
}
