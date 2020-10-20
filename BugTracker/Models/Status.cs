using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public enum StatusType
    {
        New,
        Open,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Additional Info Required")]
        AdditionalInfoRequired,
        Closed
    }
}
