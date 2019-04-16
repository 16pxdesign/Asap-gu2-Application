using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class MemberRepositories : GenericRepository<Member>, IMemberRepositories
    {
        private readonly DatabaseModel _context;
        
        
        public MemberRepositories(DatabaseModel context) : base(context)
        {
            _context = context;

        }

        public Member FindBySRU(string sru)
        {
            var member = _context.Members.Find(sru);

            return member;
        }
    }
}
