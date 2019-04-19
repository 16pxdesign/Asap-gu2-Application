using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Repo.Contracts;
using System.Dynamic;
using Application.Data.Models;
using Application.Repo;
using Newtonsoft.Json;

namespace Application.Controllers
{
    public class IndexController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public IndexController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult Index()
        {
            List<HealthIssueViewModel> list = new List<HealthIssueViewModel>();
            
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                list = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ?? new List<HealthIssueViewModel>();
                TempData["HealthIssues"] = JsonConvert.SerializeObject(list);         
                
                return PartialView("_HealthTable", list);
            }
      
            TempData["HealthIssues"] = JsonConvert.SerializeObject(list);         
            
            var model = new MemberViewModel
            {
                Player = new PlayerViewModel
                {
                    HealthIssues = list
                }
            };
            
            return View(model);            

        }

        public IActionResult AddHealth()
        {
            var model = new HealthIssueViewModel();

            return PartialView("_HealthAddForm", model);
        }
        
        [HttpPost]
        public IActionResult AddHealth(HealthIssueViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                List<HealthIssueViewModel> list = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ?? new List<HealthIssueViewModel>();
                list.Add(model);
                string json = JsonConvert.SerializeObject(list);         
                TempData["HealthIssues"] = json;
            }

            return PartialView("_HealthAddForm", model);
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
    }
}
