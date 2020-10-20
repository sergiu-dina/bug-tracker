using BugTracker.Areas.Identity.Pages.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Areas.Identity.Data
{
    public interface IUserData
    {
        IEnumerable<BugTrackerUser> GetAll();

        BugTrackerUser Get(string email);
    }
}
