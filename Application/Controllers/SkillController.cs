using System;
using System.Collections.Generic;
using Application.Data.Models;
using Application.Models;
using Application.Repo;
using Application.Repo.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class SkillController : Controller
    {
        
        private readonly UnitOfWork _unitOfWork;

        public SkillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }
        
        // GET
        public IActionResult Index()
        {
            List<Skill> list = _unitOfWork.ProfileRepository.GetSkillList();
            var model = AutoMapper.Mapper.Map<List<Skill>, List<SkillViewModel>>(list);
            return View(model);
        }

      

        public IActionResult AddEdit(int? id)
        {
            var model = new SkillViewModel();

            if (id != null)
            {
                Skill skill = _unitOfWork.ProfileRepository.GetSkillById((int) id);
                model = AutoMapper.Mapper.Map<Skill, SkillViewModel>(skill);
            }

           
                var categoryList =_unitOfWork.ProfileRepository.GetCategories();
                model.Categories = AutoMapper.Mapper.Map<List<Skill>, List<SkillViewModel>>(categoryList);
            
                
         
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(SkillViewModel model)
        {

            if (ModelState.IsValid)
            {
                var skill = AutoMapper.Mapper.Map<SkillViewModel,Skill>(model);
                _unitOfWork.ProfileRepository.AddUpdateSkill(skill);
                
                
                return RedirectToAction(nameof(Index));
            }
            
            
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _unitOfWork.ProfileRepository.DeleteSkill(id);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View(e);
            }
        }
    }
}