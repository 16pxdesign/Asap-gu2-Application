using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.Frameworks;
using Application.Models;
using Application.Models.ViewModels;
using Application.Repo;
using Application.Repo.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Controllers
{
    public class TrainingController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public TrainingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult Index()
        {
            var listOfTrainings = _unitOfWork.TraingRepositorieses.GetListOfTrainings();
            var model = AutoMapper.Mapper.Map<List<Training>, List<TrainingViewModel>>(listOfTrainings);
            return View(model);
        }

        public IActionResult CreateUpdate()
        {
            var model = new TrainingViewModel()
            {
                Activitieses = new List<ActivitiesViewModel>()
            };
            TempData["Activities"] = JsonConvert.SerializeObject(model);

            ViewBag.PlayerList  = AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(_unitOfWork.MemberRepositories.GetMemberList());

    
            ViewBag.CoachList = _unitOfWork.TraingRepositorieses.GetListOfCoaches();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateUpdate(TrainingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var save = AutoMapper.Mapper.Map<TrainingViewModel, Training>(model);
                _unitOfWork.TraingRepositorieses.AddUpdateTraining(save);
                return RedirectToAction(nameof(Index));
            }


            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.CoachList = _unitOfWork.TraingRepositorieses.GetListOfCoaches();
            var training = _unitOfWork.TraingRepositorieses.GetTraining(id);
            var model = AutoMapper.Mapper.Map<Training, TrainingViewModel>(training);
            TempData["Activities"] = JsonConvert.SerializeObject(model);
            return View("CreateUpdate", model);
        }

        [HttpPost]
        public IActionResult Edit(TrainingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var save = AutoMapper.Mapper.Map<TrainingViewModel, Training>(model);
                
                _unitOfWork.TraingRepositorieses.AddUpdateTraining(save, save.Activitieses);
                return RedirectToAction(nameof(Index));
            }


            return View("CreateUpdate", model);
        }


        public IActionResult Details(int Id)
        {
            var result = _unitOfWork.TraingRepositorieses.GetTraining(Id);
            var model = AutoMapper.Mapper.Map<Training, TrainingViewModel>(result);
            return View(model);
        }


        public IActionResult Delete(int Id)
        {
            _unitOfWork.TraingRepositorieses.DeleteTrainingById(Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddActivity(int? id)
        {
            var model = new ActivitiesViewModel();

            if (id != null)
            {
                TempData.TryGetValue("Activities", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<TrainingViewModel>(data) ??
                           new TrainingViewModel();
                model = list.Activitieses.ElementAt((int) id);
                TempData["ActivitiesID"] = id;
                string json = JsonConvert.SerializeObject(list);
                TempData["Activities"] = json;
            }
            else
            {
                TempData["ActivitiesID"] = null;
            }


            return PartialView("_ActivityAddForm", model);
        }
[HttpPost]
        public IActionResult AddActivity(ActivitiesViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("Activities", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<TrainingViewModel>(data) ??
                           new TrainingViewModel();
                if (list.Activitieses == null)
                    list.Activitieses = new List<ActivitiesViewModel>();
                TempData.TryGetValue("ActivitiesID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list.Activitieses[(int) listIndex] = model;
                }
                else
                {
                    list.Activitieses.Add(model);
                }


                string json = JsonConvert.SerializeObject(list);
                TempData["Activities"] = json;
            }

            return PartialView("_ActivityAddForm", model);
            
        }

        public IActionResult ModalFillTable(string table = null)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Activity")
            {
                var healthIssuePartialList = OnAjaxHealthTablePartialViewResult();
                return PartialView("_ActivitiesTable", healthIssuePartialList);
            }

            return null;
        }

        private TrainingViewModel OnAjaxHealthTablePartialViewResult()
        {
            TempData.TryGetValue("Activities", out object value);
            var data = value as string ?? "";
            var table = JsonConvert.DeserializeObject<TrainingViewModel>(data) ??
                        new TrainingViewModel();
            if (table.Activitieses == null)
                table.Activitieses = new List<ActivitiesViewModel>();
            TempData["Activities"] = JsonConvert.SerializeObject(table);
            return table;
        }
        
        
        [HttpPost]
        public async Task<bool> DeleteActivity(int id)
        {
            DeleteActivityFromList(id);
            return true;
        }

        private bool DeleteActivityFromList(int id)
        {
            TempData.TryGetValue("Activities", out object value);
            var data = value as string ?? "";
            var list = JsonConvert.DeserializeObject<TrainingViewModel>(data) ??
                       new TrainingViewModel();
            list.Activitieses.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["Activities"] = json;
            return true;
        }
        
    }
}