using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Add()
        {
            var memberViewModel = new MemberViewModel() {Name = "Robert"};
            var healthIssueViewModels = new List<HealthIssueViewModel>();
            healthIssueViewModels.Add(new HealthIssueViewModel(){Name = "xaxa"});
            healthIssueViewModels.Add(new HealthIssueViewModel(){Name = "xaxa"});
            healthIssueViewModels.Add(new HealthIssueViewModel(){Name = "xaxa"});
            memberViewModel.Player = new PlayerViewModel();
            memberViewModel.Player.HealthIssues = healthIssueViewModels;
 

            return View("~/Views/Partial/AddOrEdit/EditMember.cshtml",memberViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(MemberViewModel memberViewModel)
        {

           
            var healthIssueViewModel = memberViewModel.Player.HealthIssues.ElementAt(1);
            var name = healthIssueViewModel.Name;
            return View("~/Views/Partial/AddOrEdit/EditMember.cshtml",memberViewModel);
        }
    }
}