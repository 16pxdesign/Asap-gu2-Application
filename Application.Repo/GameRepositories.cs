using System.Collections.Generic;
using System.Linq;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class GameRepositories: GenericRepository<Game>, IGameRepositories
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
                var rootActivities = _context.Activities.Where(x => x.TrainingId == save.Id).ToList();
                foreach (var score in rootActivities)
                {
                    if (list.Exists(x => x.Id == score.Id))
                    {
                        _context.Activities.Remove(score);
                    }
                }

                _context.Game.Update(save);
            }
            else
                _context.Game.Add(save);

            _context.SaveChanges();
        }
    }


}