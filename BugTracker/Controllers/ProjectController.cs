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

namespace BugTracker.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectData projectData;
        private readonly ITicketData ticketData;

        public ProjectController(IProjectData projectData, ITicketData ticketData)
        {
            this.projectData = projectData;
            this.ticketData = ticketData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = projectData.GetAll();
            return View(model);
        }

        [Authorize(Roles ="Admin,Project Manager")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Project Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Project project)
        {
            if(ModelState.IsValid)
            {
                projectData.Add(project);
                return RedirectToAction("Details", new { id = project.Id });
            }
            return View();
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = projectData.Get(id);

            if(model==null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult Delete(Project project)
        {
            projectData.Delete(project.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = new ProjectTicketsViewModel();
            var project = projectData.Get(id);
            var tickets = new List<Ticket>();
            foreach(var ticket in ticketData.GetAll())
            {
                if(ticket.ProjectId==id)
                {
                    tickets.Add(ticket);
                }
            }
            model.Project = project;
            model.Tickets = tickets;
            if(model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize(Roles ="Admin,Project Manager")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = projectData.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin,Project Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                projectData.Update(project);
                return RedirectToAction("Details", new { id = project.Id });
            }
            return View(project);
        }
    }
}
