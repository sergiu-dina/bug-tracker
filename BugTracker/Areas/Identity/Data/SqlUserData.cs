using BugTracker.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Areas.Identity.Data
{
    public class SqlUserData : IUserData
    {
        private readonly AuthDbContext db;

        public SqlUserData(AuthDbContext db)
        {
            this.db = db;
        }

        public BugTrackerUser Get(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }

        public IEnumerable<BugTrackerUser> GetAll()
        {
            return db.Users.OrderBy(r=>r.FirstName);
        }
    }
}
