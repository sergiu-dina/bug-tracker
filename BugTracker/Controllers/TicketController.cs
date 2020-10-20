using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Areas.Identity.Data;
using BugTracker.Models;
using BugTracker.Models.Services;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BugTracker.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private readonly ITicketData ticketData;
        private readonly IProjectData projectData;
        private readonly UserManager<BugTrackerUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public TicketController(ITicketData ticketData, IProjectData projectData,UserManager<BugTrackerUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.ticketData = ticketData;
            this.projectData = projectData;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new List<DisplayTicketViewModel>();
            var tickets = ticketData.GetAll();
            foreach(var ticket in tickets)
            {
                var temp =new DisplayTicketViewModel();
                var project = projectData.Get(ticket.ProjectId);
                temp.Project = project;
                temp.Ticket = ticket;
                model.Add(temp);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var model = new TicketProjectViewModel();
            var projects = projectData.GetAll();
            model.Projects = new List<SelectListItem>();
            foreach(var project in projects)
            {
                var item = new SelectListItem { Text = project.Name, Value = project.Name };
                model.Projects.Add(item);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketProjectViewModel model)
        {
            var user = await userManager.GetUserAsync(User);
            model.Ticket.Submitter = user.Email;
            model.Ticket.Created = DateTime.Now;
            model.Ticket.Status = StatusType.Open;
            model.Ticket.Priority = PriorityType.None;
            var projectName=model.Selected;
            var project = projectData.GetByName(projectName);
            model.Ticket.Project = project;
            model.Ticket.Project.Id = project.Id;
            model.Ticket.Project.Name = project.Name;
            if (ModelState.IsValid)
            {
                ticketData.Add(model.Ticket);
                //return RedirectToAction("Details", new { id = project.Id });
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "Admin,Project Manager")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model=ticketData.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin,Project Manager")]
        [HttpPost]
        public IActionResult Delete(Ticket ticket)
        {
            ticketData.Delete(ticket.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var ticket = ticketData.Get(id);
            var project = projectData.Get(ticket.ProjectId);
            var model = new DisplayTicketViewModel();
            model.Project = project;
            model.Ticket = ticket;
            model.FromTickets = true;
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin,Project Manager,Developer")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new TicketUserViewModel();
            var ticket = ticketData.Get(id);
            var project = projectData.Get(ticket.ProjectId);
            var users = new List<SelectListItem>();
            var developerRole = await roleManager.FindByNameAsync("Developer");
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role: developerRole.Name))
                {
                    var name = new SelectListItem { Text = user.Email, Value = user.Email };
                    users.Add(name);
                }
            }
            model.Ticket = ticket;
            model.Project = project;
            model.Users = users;
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin,Project Manager,Developer")]
        [HttpPost]
        public IActionResult Edit(TicketUserViewModel model)
        {
            model.Ticket.Updated = DateTime.Now;
            model.Ticket.Developer = model.Selected;
            if (ModelState.IsValid)
            {
                ticketData.Update(model.Ticket);
                return RedirectToAction("Details", new { id = model.Ticket.Id });
            }
            return View(model);
        }
    }
}
