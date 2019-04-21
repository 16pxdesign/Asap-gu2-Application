using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.Models;
using AutoMapper;

namespace Application.Frameworks
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            CreateMap<GuardianViewModel, Guardian>();
            CreateMap<DoctorViewModel, Doctor>();
            CreateMap<GuardianViewModel, Guardian>();
            CreateMap<HealthIssueViewModel, HealthIssue>();
            CreateMap<KinViewModel, Kin>();
            CreateMap<Kin, KinViewModel>();

            CreateMap<Address, AddressViewModel>();
            CreateMap<AddressViewModel, Address>();

            CreateMap<MemberViewModel, Member>().ForMember(d=>d.Player, o=>o.Condition(s=>s.Type != MemberType.Member));
            CreateMap<Member, MemberViewModel>().ForMember(d => d.Player, o => o.NullSubstitute(new Player()));

            CreateMap<PlayerViewModel, Player>();
            CreateMap<Player, PlayerViewModel>().ForMember(d => d.Junior, o => o.NullSubstitute(new Junior()));
            CreateMap<JuniorViewModel, Junior>();
            CreateMap<Junior, JuniorViewModel>();
            CreateMap<SeniorViewModel, Senior>();
            CreateMap<Senior, SeniorViewModel>();
                


        }



        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperProfile>());
        }


    }
}
