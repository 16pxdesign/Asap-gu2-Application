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

        public async Task<IActionResult> CreateUpdate(int? id, string table = null)
        {
            List<HealthIssueViewModel> listHealthIssues = new List<HealthIssueViewModel>();
            listHealthIssues.Add(new HealthIssueViewModel(){Name = "2"});
            List<GuardianViewModel> listGuardians = new List<GuardianViewModel>();


            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Health")
            {
                var healthIssuePartialList = await OnAjaxHealthTablePartialViewResult();
                return PartialView("_HealthTable", healthIssuePartialList);
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Guardian")
            {
                var guardianPartialList = await OnAjaxGuardianPartialViewResult();
                return PartialView("_GuardianTable", guardianPartialList);
            }

            TempData["HealthIssues"] = JsonConvert.SerializeObject(listHealthIssues);
           TempData["Guardians"] = JsonConvert.SerializeObject(listGuardians);

            var model = new MemberViewModel
            {
                Player = new PlayerViewModel
                {
                    HealthIssues = listHealthIssues,
                    JuniorPlayer = new JuniorPlayerViewModel()
                    {
                        Guardians = listGuardians
                    }
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
                string json = JsonConvert.SerializeObject(list);
                TempData["HealthIssues"] = json;
            } else
            {
                TempData["HealthIssuesID"] = null;
            }


            return PartialView("_HealthAddForm", model);
        }


        [HttpPost]
        public async Task<IActionResult> AddHealth(HealthIssueViewModel model)
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


        [HttpPost]
        public async Task<bool> DeleteHealth(int id)
        {
            await DeleteHealthFromList(id);
            return true;
        }

        private async Task<bool> DeleteHealthFromList(int id)
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

        public async Task<IActionResult> AddGuardian(int? id)
        {
            var model = new GuardianViewModel();

            if (id != null)
            {
                TempData.TryGetValue("Guardians", out object value);
                var data = value as string ?? "";
                List<GuardianViewModel> list = JsonConvert.DeserializeObject<List<GuardianViewModel>>(data) ??
                                               new List<GuardianViewModel>();
                model = list.ElementAt((int) id);
                TempData["GuardiansID"] = id;
                string json = JsonConvert.SerializeObject(list);
                TempData["Guardians"] = json;
            }
            else
            {
                TempData["GuardiansID"] = null;
            }


            return PartialView("_GuardianAddForm", model);
        }

        [HttpPost]
        public IActionResult AddGuardian(GuardianViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("Guardians", out object value);
                var data = value as string ?? "";
                List<GuardianViewModel> list = JsonConvert.DeserializeObject<List<GuardianViewModel>>(data) ??
                                               new List<GuardianViewModel>();
                TempData.TryGetValue("GuardiansID", out object listIndex);
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
                TempData["Guardians"] = json;
            }

            return PartialView("_GuardianAddForm", model);
        }

        [HttpPost]
        public async Task<bool> DeleteGuardian(int id)
        {
            await DeleteGuardianFromList(id);
            return true;
        }

        private async Task<bool> DeleteGuardianFromList(int id)
        {
            TempData.TryGetValue("Guardians", out object value);
            var data = value as string ?? "";
            List<GuardianViewModel> list = JsonConvert.DeserializeObject<List<GuardianViewModel>>(data) ??
                                              new List<GuardianViewModel>();
            list.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["Guardians"] = json;
            return true;
        }

        [NonAction]
        private async Task<List<GuardianViewModel>> OnAjaxGuardianPartialViewResult()
        {
            TempData.TryGetValue("Guardians", out object value);
            var data = value as string ?? "";
            List<GuardianViewModel> table = JsonConvert.DeserializeObject<List<GuardianViewModel>>(data) ??
                                            new List<GuardianViewModel>();
            TempData["Guardians"] = JsonConvert.SerializeObject(table);
            return table;
        }
        
    }
}