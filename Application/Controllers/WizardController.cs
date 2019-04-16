using System;
using Application.Data.Models;
using Application.Repo;
using Application.Repo.Contracts;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class WizardController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public WizardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        // GET
        public IActionResult Index()
        {
            return
                View();
        }

        public IActionResult Member()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Member(MemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: SAVE MEMBER
                var member = new Member();
                if (model.Type == MemberType.Member)
                    model.Player = null;

                AutoMapper.Mapper.Map(model, member);
                _unitOfWork.MemberRepositories.Add(member);
                if (model.Type == MemberType.Junior || model.Type == MemberType.Senior)
                    return View("~/Views/Wizard/MemberDoctor.cshtml", model);
            }

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MemberDoctor(MemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.SRU != null)
                {

                    var member = _unitOfWork.MemberRepositories.FindBySRU(model.SRU);           
                    AutoMapper.Mapper.Map(model.Player.Doctor, member.Player.Doctor);
                    _unitOfWork.MemberRepositories.Update(member);
                    if(member.Type == MemberType.Senior)
                    return View("~/Views/Wizard/MemberKin.cshtml", model);
                    
                }
                else
                {
                    throw new Exception("Lost track on user");
                }


            }


            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MemberKin(MemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.SRU != null)
                {
                    //TODO: FIND MEMBER
                    var member = _unitOfWork.MemberRepositories.FindBySRU(model.SRU);
             
                    member.Player.Senior = new Senior();
                    AutoMapper.Mapper.Map(model.Player.SeniorPlayer, member.Player.Senior);
                    _unitOfWork.MemberRepositories.Update(member);
                }
                else
                {
                    throw new Exception("Lost track on user");
                }

                
            }

            return View(model);
        }
    }
}
   