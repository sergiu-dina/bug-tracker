using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models.Services
{
    public interface IProjectData
    {
        IEnumerable<Project> GetAll();
        Project Get(int id);
        Project GetByName(string name);
        void Add(Project project);
        void Update(Project project);
        void Delete(int id);
        bool HasUser(Project project,string id);
    }
}
