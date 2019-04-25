using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.Models;
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
            var listOfTrainings = _unitOfWork.TrainingRepositories.GetListOfTrainings();
            var model = AutoMapper.Mapper.Map<List<Training>, List<TrainingViewModel>>(listOfTrainings);
            return View(model);
        }

        public IActionResult CreateUpdate()
        {
            var model = new TrainingViewModel()
            {
                Activities = new List<ActivitiesViewModel>()
            };
            TempData["Activities"] = JsonConvert.SerializeObject(model);

            ViewBag.PlayerList =
                AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(
                    _unitOfWork.MemberRepositories.GetPlayerList());


            ViewBag.CoachList = _unitOfWork.TrainingRepositories.GetListOfCoaches();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateUpdate(TrainingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var save = AutoMapper.Mapper.Map<TrainingViewModel, Training>(model);
                _unitOfWork.TrainingRepositories.AddUpdateTraining(save, save.Activities);
                _unitOfWork.TrainingRepositories.InsertUpdateAttendance(save, model.Attended);
                return RedirectToAction(nameof(Index));
            }


            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.PlayerList =
                AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(
                    _unitOfWork.MemberRepositories.GetPlayerList());

            ViewBag.CoachList = _unitOfWork.TrainingRepositories.GetListOfCoaches();
            var training = _unitOfWork.TrainingRepositories.GetTraining(id);
            var model = AutoMapper.Mapper.Map<Training, TrainingViewModel>(training);
            model.Attended = _unitOfWork.TrainingRepositories.GetSelectedAttendance(training);
            TempData["Activities"] = JsonConvert.SerializeObject(model);
            return View("CreateUpdate", model);
        }

        [HttpPost]
        public IActionResult Edit(TrainingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var save = AutoMapper.Mapper.Map<TrainingViewModel, Training>(model);
                _unitOfWork.TrainingRepositories.AddUpdateTraining(save, save.Activities);
                _unitOfWork.TrainingRepositories.InsertUpdateAttendance(save, model.Attended);

                return RedirectToAction(nameof(Index));
            }


            return View("CreateUpdate", model);
        }


        public IActionResult Details(int Id)
        {
            var result = _unitOfWork.TrainingRepositories.GetTraining(Id);
            var model = AutoMapper.Mapper.Map<Training, TrainingViewModel>(result);

            List<Member> attendanceList = _unitOfWork.TrainingRepositories.GetAttendenceList(result.Id);
            model.Attendance = AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(attendanceList);
            return View(model);
        }


        public IActionResult Delete(int Id)
        {
            _unitOfWork.TrainingRepositories.DeleteTrainingById(Id);
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
                model = list.Activities.ElementAt((int) id);
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
                if (list.Activities == null)
                    list.Activities = new List<ActivitiesViewModel>();
                TempData.TryGetValue("ActivitiesID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list.Activities[(int) listIndex] = model;
                }
                else
                {
                    list.Activities.Add(model);
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
                var activityPartialList = OnAjaxActivityTablePartialViewResult();
                return PartialView("_ActivitiesTable", activityPartialList);
            }

            return null;
        }

        private TrainingViewModel OnAjaxActivityTablePartialViewResult()
        {
            TempData.TryGetValue("Activities", out object value);
            var data = value as string ?? "";
            var table = JsonConvert.DeserializeObject<TrainingViewModel>(data) ??
                        new TrainingViewModel();
            if (table.Activities == null)
                table.Activities = new List<ActivitiesViewModel>();
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
            list.Activities.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["Activities"] = json;
            return true;
        }
    }
}