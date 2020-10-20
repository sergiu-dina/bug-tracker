using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugTracker.Models;
using Microsoft.AspNetCore.Authorization;
using BugTracker.Areas.Identity.Data;
using BugTracker.Models.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Controllers
{
    [Authorize]
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITicketData ticketData;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<BugTrackerUser> userManager;

        public HomeController(ILogger<HomeController> logger, ITicketData ticketData, RoleManager<IdentityRole> roleManager, UserManager<BugTrackerUser> userManager)
        {
            _logger = logger;
            this.ticketData = ticketData;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            var noneCount = 0;
            var lowCount = 0;
            var mediumCount = 0;
            var highCount = 0;
            var none = "None";
            var low = "Low";
            var medium = "Medium";
            var high = "High";
            foreach(var ticket in ticketData.GetAll())
            {
                if (none.Equals(ticket.Priority.ToString()))
                {
                    noneCount++;
                }
                if (low.Equals(ticket.Priority.ToString()))
                {
                    lowCount++;
                }
                if (medium.Equals(ticket.Priority.ToString()))
                {
                    mediumCount++;
                }
                if (high.Equals(ticket.Priority.ToString()))
                {
                    highCount++;
                }
            }
            dataPoints.Add(new DataPoint(none, noneCount));
            dataPoints.Add(new DataPoint(low, lowCount));
            dataPoints.Add(new DataPoint(medium, mediumCount));
            dataPoints.Add(new DataPoint(high, highCount));

            List<DataPoint> dataPoints2 = new List<DataPoint>();
            var newCount = 0;
            var openCount = 0;
            var progressCount = 0;
            var additionalCount = 0;
            var closedCount = 0;
            var neew = "New";
            var open = "Open";
            var progress = "InProgress";
            var additional = "AdditionalInfoRequired";
            var closed = "Closed";
            foreach (var ticket in ticketData.GetAll())
            {
                if (neew.Equals(ticket.Status.ToString()))
                {
                    newCount++;
                }
                if (open.Equals(ticket.Status.ToString()))
                {
                    openCount++;
                }
                if (progress.Equals(ticket.Status.ToString()))
                {
                    progressCount++;
                }
                if (additional.Equals(ticket.Status.ToString()))
                {
                    additionalCount++;
                }
                if (closed.Equals(ticket.Status.ToString()))
                {
                    closedCount++;
                }
            }
            dataPoints2.Add(new DataPoint(neew, newCount));
            dataPoints2.Add(new DataPoint(open, openCount));
            dataPoints2.Add(new DataPoint("In Progress", progressCount));
            dataPoints2.Add(new DataPoint("More Info", additionalCount));
            dataPoints2.Add(new DataPoint(closed, closedCount));

            List<DataPoint> dataPoints3 = new List<DataPoint>();
            var none2Count = 0;
            var featureCount = 0;
            var bugsCount = 0;
            var trainingCount = 0;
            var otherCount = 0;
            var none2 = "None";
            var feature = "FeatureRequest";
            var bugs = "BugsError";
            var training = "TrainingDocumentRequest";
            var other = "OtherComments";
            foreach (var ticket in ticketData.GetAll())
            {
                if (none2.Equals(ticket.Type.ToString()))
                {
                    none2Count++;
                }
                if (feature.Equals(ticket.Type.ToString()))
                {
                    featureCount++;
                }
                if (bugs.Equals(ticket.Type.ToString()))
                {
                    bugsCount++;
                }
                if (training.Equals(ticket.Type.ToString()))
                {
                    trainingCount++;
                }
                if (other.Equals(ticket.Type.ToString()))
                {
                    otherCount++;
                }
            }
            dataPoints3.Add(new DataPoint("Feature", featureCount));
            dataPoints3.Add(new DataPoint("Bugs/Errors", bugsCount));
            dataPoints3.Add(new DataPoint("Document", trainingCount));
            dataPoints3.Add(new DataPoint("Comments", otherCount));

            List<DataPoint> dataPoints4 = new List<DataPoint>();
            var adminCount = 0;
            var managerCount = 0;
            var developerCount = 0;
            var submitterCount = 0;
            var admin = "Admin";
            var manager = "Project Manager";
            var developer = "Developer";
            var submitter = "Submitter";
            foreach (var user in userManager.Users)
            {
                foreach (var role in roleManager.Roles)
                {
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        if(role.Name==admin)
                            adminCount++;
                        if (role.Name == manager)
                            managerCount++;
                        if (role.Name == developer)
                            developerCount++;
                        if (role.Name == submitter)
                            submitterCount++;
                    }
                }
            }
            dataPoints4.Add(new DataPoint(admin, adminCount));
            dataPoints4.Add(new DataPoint(manager, managerCount));
            dataPoints4.Add(new DataPoint(developer, developerCount)); ;
            dataPoints4.Add(new DataPoint(submitter, submitterCount));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints4);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
