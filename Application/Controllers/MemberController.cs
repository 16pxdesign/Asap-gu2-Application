using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Repo.Contracts;
using Application.Data.Models;
using Application.Repo;
using Newtonsoft.Json;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using ModelStateDictionary = Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;

namespace Application.Controllers
{
    public class MemberController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public MemberController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult CreateUpdate(string id = null, string table = null)
        {

            MemberViewModel model = null;

            TempData["EditMember"] = false;
            if (id != null)
            {
                TempData["EditMember"] = true;
                var member = _unitOfWork.MemberRepositories.FindBySRU(id);
                model = AutoMapper.Mapper.Map<Member, MemberViewModel>(member);
            }


            if (model == null)
                model = new MemberViewModel();

            TempData["HealthIssues"] = JsonConvert.SerializeObject(model.Player);
            TempData["Guardians"] = JsonConvert.SerializeObject(model.Player.Junior);

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateUpdate(MemberViewModel model)
        {
            if (model.Type == MemberType.Member)
            {
                IgnoreModelStateProperty(ModelState, "Player");
            }

            if (model.Type == MemberType.Junior)
            {
                IgnoreModelStateProperty(ModelState, "Player.Senior");
            }

            if (model.Type == MemberType.Senior)
            {
                IgnoreModelStateProperty(ModelState, "Player.Junior");
            }

            if (ModelState.IsValid)
            {
                bool isEdit = (bool) (TempData["EditMember"] ?? false);
                var member = AutoMapper.Mapper.Map<MemberViewModel, Member>(model);

                if (isEdit)
                {
                    _unitOfWork.MemberRepositories.InsertEditMember(member);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    if (!_unitOfWork.MemberRepositories.IsMemberExist(member.SRU))
                    {
                        _unitOfWork.MemberRepositories.InsertEditMember(member);
                    }
                    else
                    {
                        ModelState.AddModelError("Exist", "User with this id exist");
                        return View(model);
                    }


                    return RedirectToAction(nameof(Index));
                }
            }


            return View(model);
        }
        
        public IActionResult ModalFillTable(string table = null)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Health")
            {
                var healthIssuePartialList = OnAjaxHealthTablePartialViewResult();
                return PartialView("_HealthTable", healthIssuePartialList);
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Guardian")
            {
                var guardianPartialList = OnAjaxGuardianPartialViewResult();
                return PartialView("_GuardianTable", guardianPartialList);
            }

            return null;
        }

        private void IgnoreModelStateProperty(ModelStateDictionary modelState, string key)
        {
            foreach (var modelError in modelState)
            {
                string propertyName = modelError.Key;

                if (propertyName.Contains(key))
                {
                    ModelState[propertyName].Errors.Clear();
                    //Remove to make State valid
                    ModelState.Remove(propertyName);
                }
            }
        }


        [NonAction]
        private PlayerViewModel OnAjaxHealthTablePartialViewResult()
        {
            TempData.TryGetValue("HealthIssues", out object value);
            var data = value as string ?? "";
            var table = JsonConvert.DeserializeObject<PlayerViewModel>(data) ??
                        new PlayerViewModel();
            if (table.HealthIssues == null)
                table.HealthIssues = new List<HealthIssueViewModel>();
            TempData["HealthIssues"] = JsonConvert.SerializeObject(table);
            return table;
        }

        public IActionResult AddHealth(int? id)
        {
            var model = new HealthIssueViewModel();

            if (id != null)
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<PlayerViewModel>(data) ??
                           new PlayerViewModel();
                model = list.HealthIssues.ElementAt((int) id);
                TempData["HealthIssuesID"] = id;
                string json = JsonConvert.SerializeObject(list);
                TempData["HealthIssues"] = json;
            }
            else
            {
                TempData["HealthIssuesID"] = null;
            }


            return PartialView("_HealthAddForm", model);
        }


        [HttpPost]
        public IActionResult AddHealth(HealthIssueViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("HealthIssues", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<PlayerViewModel>(data) ??
                           new PlayerViewModel();
                if (list.HealthIssues == null)
                    list.HealthIssues = new List<HealthIssueViewModel>();
                TempData.TryGetValue("HealthIssuesID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list.HealthIssues[(int) listIndex] = model;
                }
                else
                {
                    list.HealthIssues.Add(model);
                }


                string json = JsonConvert.SerializeObject(list);
                TempData["HealthIssues"] = json;
            }

            return PartialView("_HealthAddForm", model);
        }


        [HttpPost]
        public async Task<bool> DeleteHealth(int id)
        {
            DeleteHealthFromList(id);
            return true;
        }

        private bool DeleteHealthFromList(int id)
        {
            TempData.TryGetValue("HealthIssues", out object value);
            var data = value as string ?? "";
            var list = JsonConvert.DeserializeObject<PlayerViewModel>(data) ??
                       new PlayerViewModel();
            list.HealthIssues.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["HealthIssues"] = json;
            return true;
        }

        public IActionResult AddGuardian(int? id)
        {
            var model = new GuardianViewModel();

            if (id != null)
            {
                TempData.TryGetValue("Guardians", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<JuniorViewModel>(data) ??
                           new JuniorViewModel();
                model = list.Guardians.ElementAt((int) id);
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
                var list = JsonConvert.DeserializeObject<JuniorViewModel>(data) ??
                           new JuniorViewModel();
                if (list.Guardians == null)
                    list.Guardians = new List<GuardianViewModel>();

                TempData.TryGetValue("GuardiansID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list.Guardians[(int) listIndex] = model;
                }
                else
                {
                    list.Guardians.Add(model);
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
            JuniorViewModel list = JsonConvert.DeserializeObject<JuniorViewModel>(data) ??
                                   new JuniorViewModel();
            if (list.Guardians == null)
                list.Guardians = new List<GuardianViewModel>();

            list.Guardians.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["Guardians"] = json;
            return true;
        }

        [NonAction]
        private JuniorViewModel OnAjaxGuardianPartialViewResult()
        {
            TempData.TryGetValue("Guardians", out object value);
            var data = value as string ?? "";
            JuniorViewModel table = JsonConvert.DeserializeObject<JuniorViewModel>(data) ??
                                    new JuniorViewModel();
            TempData["Guardians"] = JsonConvert.SerializeObject(table);

            return table;
        }

        public IActionResult Index()
        {
            var memberList = _unitOfWork.MemberRepositories.GetMemberList();
            var list = AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(memberList);
            return View(list);
        }


        public IActionResult Details(string sru)
        {
            var member = _unitOfWork.MemberRepositories.FindBySRU(sru);
            var model = AutoMapper.Mapper.Map<Member, MemberViewModel>(member);
            return View(model);
        }

        public IActionResult Delete(string sru)
        {
            _unitOfWork.MemberRepositories.DeleteBySRU(sru);
            return RedirectToAction(nameof(Index));
        }
    }
}