using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Application.Data.Models;
using Application.Repo.Contracts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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

        public Exception InsertEditMember(Member member)
        {
            var isMemberExist = IsMemberExist(member.SRU);
            
            switch (member.Type)
            {
                case MemberType.Senior:
                    member.Player.Junior = null;
                    break;
                case MemberType.Junior:
                    member.Player.Senior = null;
                    break;
                case MemberType.Member:
                   member.Player = null;
                    break;
                
            }

            if (!isMemberExist)
                _context.Members.Add(member);
            else
            {
                _context.Members.Remove(_context.Members.Find(member.SRU));

                _context.Members.Add(member);
                _context.SaveChanges();
            }
            
            _context.SaveChanges();

            return null;
        }

        public bool IsMemberExist(string sru)
        {
            var exits = _context.Members.Where(x => x.SRU == sru).AsNoTracking().FirstOrDefault();
            return exits != null;
        }
    }
}