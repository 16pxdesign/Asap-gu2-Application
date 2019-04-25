using System.Collections.Generic;
using System.Linq;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class GameRepositories : GenericRepository<Game>, IGameRepositories
    {
        private readonly DatabaseModel _context;


        public GameRepositories(DatabaseModel context) : base(context)
        {
            _context = context;
        }


        public List<Game> GetListOfGames()
        {
            return _context.Game.ToList();
        }

        public void AddUpdateGame(Game save, List<Scores> list = null)
        {
            if (_context.Game.Any(x => x.Id == save.Id))
            {
                var rootScores = _context.Scores.Where(x => x.GameId == save.Id).ToList();
                foreach (var score in rootScores)
                {
                    if (list.Exists(x => x.Id == score.Id))
                    {
                        _context.Scores.Remove(score);
                    }
                }

                _context.Game.Update(save);
            }
            else
                _context.Game.Add(save);

            _context.SaveChanges();
        }

        public List<Scores> GetGameScores(Game game)
        {
            return _context.Scores.Where(x => x.GameId == game.Id).OrderBy(x => x.Half).ToList();
        }

        public void DeleteGame(int id)
        {
            var result = _context.Game.Find(id);

            _context.Remove(result);
            _context.SaveChanges();
        }
    }
}