using BugTracker.Areas.Identity.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Submitter { get; set; }
        public string Developer { get; set; }

        [Display(Name ="Status of a ticket")]
        public StatusType Status { get; set; }

        [Display(Name ="Priority of a ticket")]
        public PriorityType Priority { get; set; }
        
        [Display(Name ="Type of a ticket")]
        public ProjectType Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
