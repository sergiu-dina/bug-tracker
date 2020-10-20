using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Areas.Identity.Data;
using BugTracker.Data;
using BugTracker.Models;
using BugTracker.Models.Services;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProjectUsersController : Controller
    {
        private readonly IProjectData projectData;
        private readonly UserManager<BugTrackerUser> userManager;
        private readonly AuthDbContext db;
        private readonly RoleManager<IdentityRole> roleManager;

        public ProjectUsersController(IProjectData projectData, UserManager<BugTrackerUser> userManager, AuthDbContext db, RoleManager<IdentityRole> roleManager)
        {
            this.projectData = projectData;
            this.userManager = userManager;
            this.db = db;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var projects = projectData.GetAll();
            return View(projects);
        }

        [HttpGet]
        public async Task<IActionResult> EditProjectUsers(int id)
        {
            var project = projectData.Get(id);
            if (project == null)
            {
                ViewBag.ErrorMessage = $"Role with Id= {id} cannot be found";
                return View("NotFound");
            }

            var adminRole = await roleManager.FindByNameAsync("Admin");
            var managerRole = await roleManager.FindByNameAsync("Project Manager");
            var users = new List<BugTrackerUser>();
            foreach(var user in userManager.Users)
            {
                if(await userManager.IsInRoleAsync(user,role:adminRole.Name))
                {
                    users.Add(user);
                }
                if (await userManager.IsInRoleAsync(user, role: managerRole.Name))
                {
                    users.Add(user);
                }
            }


            var model = new List<UserProjectViewModel>();
            foreach (var user in users)
            {
                var userProjectViewModel = new UserProjectViewModel
                {
                    ProjectId=project.Id,
                    UserId = user.Id,
                    UserName = user.UserName
                };
                foreach (var existingUser in project.Users)
                    if (user.Id == existingUser.Id)
                    {
                        userProjectViewModel.IsSelected = true;
                    }
                    else
                    {
                        userProjectViewModel.IsSelected = false;
                    }
                model.Add(userProjectViewModel);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProjectUsers(List<UserProjectViewModel> model)
        {
            var project = projectData.Get(model[0].ProjectId);
            if (project == null)
            {
                ViewBag.ErrorMessage = $"Role with Id= {model[0].ProjectId} cannot be found";
                return View("NotFound");
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);
                if (model[i].IsSelected && !(projectData.HasUser(project, model[i].UserId)))
                {
                    project.Users.Add(user);
                    db.SaveChanges();
                }
                else if (!model[i].IsSelected)
                {
                    project.Users.Remove(user);
                    db.SaveChanges();
                }
                else
                {
                    continue;
                }

                if (i < (model.Count - 1))
                    continue;
                else
                    return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

    }
}
