using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
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
            return _context.Members.Find(sru);

        }


        public List<Member> GetMemberList()
        {
            return _context.Members.ToList();
        }

        public List<Member> GetPlayerList()
        {
            return _context.Members.Where(x => x.Type != MemberType.Member).ToList();
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
                    if ( _context.Junior.Any(o => o.SRU == member.SRU))
                        _context.Junior.Remove(_context.Junior.Single(x=>x.SRU==member.SRU));
                    _context.SaveChanges();
                    member.Player.Junior = null;
                    break;
                case MemberType.Junior:
                    if ( _context.Senior.Any(o => o.SRU == member.SRU))
                    _context.Senior.Remove(_context.Senior.Single(x=>x.SRU==member.SRU));

                    _context.SaveChanges();
                    member.Player.Senior = null;
                    break;
                case MemberType.Member:
                    if ( _context.Player.Any(o => o.SRU == member.SRU))
                    _context.Player.Remove(_context.Player.Single(x=>x.SRU==member.SRU));
                    _context.SaveChanges();
                    member.Player = null;
                    break;
            }

            if (!isMemberExist)
                _context.Members.Add(member);
            else
            {
                
                _context.Members.Update(member);
            }

            _context.SaveChanges();

            return null;
        }

        public bool IsMemberExist(string sru)
        {
            var exits = _context.Members.Where(x => x.SRU == sru).AsNoTracking().FirstOrDefault();
            return exits != null;
        }

        public bool IsPlayer(string id)
        {
            var any = _context.Player.Any(x=>x.SRU == id);
            return any;
        }

        public Game FindGame(int id)
        {
            return _context.Game.Find(id);
        }
    }
}