using System.Collections.Generic;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class FormsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            var model = new MemberViewModel()
            {
                Player = new PlayerViewModel()
                {
                    HealthIssues = new List<HealthIssueViewModel>()
                    
                    
                }
            };
            return View(new MemberViewModel());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MemberViewModel model)
        {
            ModelState.AddModelError(string.Empty, "Student Name already exists.");
            return View(model);
        }

        public IActionResult AddMember()
        {

            return PartialView("~/Views/Partial/AddOrEdit/Health.cshtml", new HealthIssueViewModel());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Check(HealthIssueViewModel model)
        {
            ModelState.AddModelError(string.Empty, "Student Name already exists.");
            return PartialView("~/Views/Partial/AddOrEdit/Health.cshtml", model);
        }
        
    }
}