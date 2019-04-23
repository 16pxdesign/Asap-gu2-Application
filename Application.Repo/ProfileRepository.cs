using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
    {
        private readonly DatabaseModel _context;


        public ProfileRepository(DatabaseModel context) : base(context)
        {
            _context = context;
        }

        public void AddUpdateSkill(Skill skill)
        {
            throw new System.NotImplementedException();
        }

        public void AddUpdateProfile(Profile profile)
        {
            throw new System.NotImplementedException();
        }
    }
}