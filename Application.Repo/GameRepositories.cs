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
    }


}