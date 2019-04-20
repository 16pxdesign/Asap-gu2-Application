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
    public class MemberController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public MemberController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public async Task<IActionResult> CreateUpdate(int? id)
        {
            List<HealthIssueViewModel> list = new List<HealthIssueViewModel>();

            list.Add(new HealthIssueViewModel() {Name = "1"});
            list.Add(new HealthIssueViewModel() {Name = "1"});
            list.Add(new HealthIssueViewModel() {Name = "1"});

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                var table = await OnAjaxHealthTablePartialViewResult();
                return PartialView("_HealthTable", table);
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

        [HttpPost]
        public async Task<IActionResult> CreateUpdate(MemberViewModel model)
        {

            return View(model);
        }


        [NonAction]
        private async Task<List<HealthIssueViewModel>> OnAjaxHealthTablePartialViewResult()
        {
            TempData.TryGetValue("HealthIssues", out object value);
            var data = value as string ?? "";
            List<HealthIssueViewModel> table = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ??
                                               new List<HealthIssueViewModel>();
            TempData["HealthIssues"] = JsonConvert.SerializeObject(table);
            return table;
        }

        public async Task<IActionResult> AddHealth(int? id)
        {
            var model = new HealthIssueViewModel();

            if (id != null)
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                List<HealthIssueViewModel> list = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ??
                                                  new List<HealthIssueViewModel>();
                model = list.ElementAt((int) id);
                TempData["HealthIssuesID"] = id;
                //list.RemoveAt((int) id);
                string json = JsonConvert.SerializeObject(list);
                TempData["HealthIssues"] = json;
            }

            ViewBag.SUKA = "etam";
            return PartialView("_HealthAddForm", model);
        }


        [HttpPost]
        public async Task<bool> Delete(int id)
        {
            await DeleteFromList(id);
            return true;
        }

        private async Task<bool> DeleteFromList(int id)
        {
            TempData.TryGetValue("HealthIssues", out object value);
            var data = value as string ?? "";
            List<HealthIssueViewModel> list = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ??
                                              new List<HealthIssueViewModel>();
            list.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["HealthIssues"] = json;
            return true;
        }

        [HttpPost]
        public IActionResult AddHealth(HealthIssueViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                List<HealthIssueViewModel> list = JsonConvert.DeserializeObject<List<HealthIssueViewModel>>(data) ??
                                                  new List<HealthIssueViewModel>();
                TempData.TryGetValue("HealthIssuesID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list[(int) listIndex] = model;
                }
                else
                {
                    list.Add(model);
                }


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
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}