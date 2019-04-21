using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Member> GetMemberList()
        {
            return _context.Members.ToList();
        }

        public void DeleteBySRU(string sru)
        {
            var member = _context.Members.Find(sru);
            
            _context.Remove(member);
            _context.SaveChanges();
        }

        public void AddNewMember(Member member)
        {
            //TODO: if exist update
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void EditMember(Member member)
        {
            _context.Members.Update(member);
            _context.SaveChanges();
        }
    }
}
