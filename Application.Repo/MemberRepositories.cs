using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class MemberRepositories : GenericRepository<Member>, IMemberRepositories
    {
        public MemberRepositories(DatabaseModel context) : base(context)
        {
        }
    }
}
