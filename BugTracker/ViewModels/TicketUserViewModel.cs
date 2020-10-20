using BugTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class TicketUserViewModel
    {
        public Ticket Ticket { get; set; } = new Ticket();
        public Project Project { get; set; }
        public List<SelectListItem> Users { get; set; }

        [Display(Name = "Developer")]
        public string Selected { get; set; }
    }
}
