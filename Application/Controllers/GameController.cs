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
            GameViewModel model = new GameViewModel {Scores = new List<ScoreViewModel>()};
            TempData["Scores"] = JsonConvert.SerializeObject(model);
            if (id != null)
            {
                var game = _unitOfWork.MemberRepositories.FindGame((int) id);
                model = AutoMapper.Mapper.Map<Game, GameViewModel>(game);
                var gameScores = _unitOfWork.GameRepositories.GetGameScores(game);
                model.Scores = AutoMapper.Mapper.Map<List<Scores>, List<ScoreViewModel>>(gameScores);
                TempData["Scores"] = JsonConvert.SerializeObject(model);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(GameViewModel model)
        {
            if (ModelState.IsValid)
            {
                var save = AutoMapper.Mapper.Map<GameViewModel, Game>(model);
                _unitOfWork.GameRepositories.AddUpdateGame(save, save.Scores);

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var result = _unitOfWork.GameRepositories.GetById(id);
            var model = AutoMapper.Mapper.Map<Game, GameViewModel>(result);

            return View(model);
            
        }

        public IActionResult Delete(int id)
        {
            _unitOfWork.GameRepositories.DeleteGame(id);
            return RedirectToAction(nameof(Index));
            
        }

        public IActionResult AddScore(int? id)
        {
            var model = new ScoreViewModel();

            if (id != null)
            {
                TempData.TryGetValue("Scores", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<GameViewModel>(data) ??
                           new GameViewModel();
                model = list.Scores.ElementAt((int) id);
                TempData["ScoresID"] = id;
                string json = JsonConvert.SerializeObject(list);
                TempData["Scores"] = json;
            }
            else
            {
                TempData["ScoresID"] = null;
            }


            return PartialView("_AddScore", model);
        }

        [HttpPost]
        public IActionResult AddScore(ScoreViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("Scores", out object value);
                var data = value as string ?? "";
                var list = JsonConvert.DeserializeObject<GameViewModel>(data) ??
                           new GameViewModel();
                if (list.Scores == null)
                    list.Scores = new List<ScoreViewModel>();
                TempData.TryGetValue("ScoresID", out object listIndex);
                listIndex = listIndex as int? ?? null;
                if (listIndex != null)
                {
                    list.Scores[(int) listIndex] = model;
                }
                else
                {
                    list.Scores.Add(model);
                }


                string json = JsonConvert.SerializeObject(list);
                TempData["Scores"] = json;
            }

            return PartialView("_AddScore", model);
        }

        [HttpPost]
        public async Task<bool> DeleteScore(int id)
        {
            DeleteScoreFromList(id);
            return true;
        }

        private void DeleteScoreFromList(int id)
        {
            TempData.TryGetValue("Scores", out object value);
            var data = value as string ?? "";
            var list = JsonConvert.DeserializeObject<GameViewModel>(data) ??
                       new GameViewModel();
            list.Scores.RemoveAt(id);
            string json = JsonConvert.SerializeObject(list);
            TempData["Scores"] = json;
        }

        public IActionResult ModalFillTable(string table = null)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" && table == "Scores")
            {
                var scorePartialList = OnAjaxScoreTablePartialViewResult();
                return PartialView("_ScoreTable", scorePartialList);
            }

            return null;
        }

        private GameViewModel OnAjaxScoreTablePartialViewResult()
        {
            TempData.TryGetValue("Scores", out object value);
            var data = value as string ?? "";
            var table = JsonConvert.DeserializeObject<GameViewModel>(data) ??
                        new GameViewModel();
            if (table.Scores == null)
                table.Scores = new List<ScoreViewModel>();
            TempData["Scores"] = JsonConvert.SerializeObject(table);
            table.Scores = table.Scores.OrderBy(x => x.Half).ToList();
            return table;
        }
    }
}