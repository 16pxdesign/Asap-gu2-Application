using System;
using System.Collections.Generic;
using Application.Data.Models;
using Application.Models.ViewModels;
using Application.Repo;
using Application.Repo.Contracts;
using Microsoft.AspNetCore.Mvc;

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
            ViewBag.CoachList = _unitOfWork.TraingRepositorieses.GetListOfCoaches();
            var m = new TrainingViewModel() {Id = 1, Location = "lol"};
            return View(m);
        }
[HttpPost]
        public IActionResult CreateUpdate(TrainingViewModel model)
        {
   
            if (ModelState.IsValid)
            {
   
                var save = AutoMapper.Mapper.Map<TrainingViewModel, Training>(model);
                _unitOfWork.TraingRepositorieses.AddUpdateTraining(save);
            }
            else
            {
                ModelState.AddModelError("Error","Try Again");
            }

            return View(model);
        }

        public IActionResult Details(string Id)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Delete(string Id)
        {
            throw new System.NotImplementedException();
        }
    }
}