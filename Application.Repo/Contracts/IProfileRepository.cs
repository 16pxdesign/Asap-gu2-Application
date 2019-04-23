using System;
using Application.Data.Models;

namespace Application.Repo.Contracts
{
    public interface IProfileRepository
    {
        void AddUpdateSkill(Skill skill);
        void AddUpdateProfile(Profile profile);
      
    }
}