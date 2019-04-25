using System.Collections.Generic;
using System.Linq;
using Application.Data.Models;
using Application.Models;
using Application.Repo;
using Application.Repo.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class GameController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public GameController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }
        
        public IActionResult Index()
        {
            List<Game> list = _unitOfWork.GameRepositories.GetListOfGames();
            var model = AutoMapper.Mapper.Map<List<Game>, List<GameViewModel>>(list);
            return View(model.AsEnumerable());
        }

        public IActionResult AddEdit(int? id)
        {
            GameViewModel model = null;

            if (id != null)
            {
                var game = _unitOfWork.MemberRepositories.FindGame((int)id);
                model = AutoMapper.Mapper.Map<Game, GameViewModel>(game);
            }


            if (model == null)
                model = new GameViewModel();

            return View(model);

        }
        
        [HttpPost]
        public IActionResult AddEdit(GameViewModel model)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Details(int id)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}