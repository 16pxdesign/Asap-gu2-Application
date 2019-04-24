using System;
using System.Collections.Generic;
using Application.Data.Models;
using Application.Models;
using Application.Repo;
using Application.Repo.Contracts;
using Microsoft.AspNetCore.Mvc;
namespace Application.Controllers
{
    public class ProfileController : Controller
    {
        
        private readonly UnitOfWork _unitOfWork;

        public ProfileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult Index()
        {
            var memberList = _unitOfWork.MemberRepositories.GetPlayerList();
            var list = AutoMapper.Mapper.Map<List<Member>, List<MemberViewModel>>(memberList);
            return View(list);
        }

        public IActionResult Evaluate(int? id)
        {
            var model = new EvalutationViewModel();
            model.Player = new MemberViewModel()
            {
                SRU = "123",
                Name = "Ok"
                
            };
            model.Categories = AutoMapper.Mapper.Map<List<Skill>,List<SkillViewModel>>( _unitOfWork.ProfileRepository.GetCategories());
            model.Skills = AutoMapper.Mapper.Map<List<Skill>,List<SkillViewModel>>( _unitOfWork.ProfileRepository.GetSkills());
            
            model.Scores = new List<ProfileViewModel>();
            model.Scores.Add(new ProfileViewModel(){});


            return View(model);
        }

        [HttpPost]
        public IActionResult Evaluate(EvalutationViewModel model)
        {
            
            return View(model);
        }

    }
}