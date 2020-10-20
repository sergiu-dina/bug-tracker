using BugTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class TicketProjectViewModel
    {
        public Ticket Ticket { get; set; } = new Ticket();
        public List<SelectListItem> Projects { get; set; }

        [Display(Name = "Project")]
        public string Selected { get; set; }
    }
}
