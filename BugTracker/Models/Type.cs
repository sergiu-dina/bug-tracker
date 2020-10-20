using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public enum ProjectType
    {
        None,
        [Display(Name = "Feature Request")]
        FeatureRequest,
        [Display(Name = "Bugs Error")]
        BugsError,
        [Display(Name = "Training/Document Request")]
        TrainingDocumentRequest,
        [Display(Name = "Other Comments")]
        OtherComments
    }
}
