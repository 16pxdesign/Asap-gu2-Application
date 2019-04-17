using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.ViewModels;
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

            CreateMap<MemberViewModel, Member>();                
            CreateMap<Member, MemberViewModel>();
            
            CreateMap<PlayerViewModel, Player>();        
            CreateMap<Player, PlayerViewModel>();

            CreateMap<JuniorPlayerViewModel, Junior>();
            CreateMap<Junior, JuniorPlayerViewModel>();
            CreateMap<SeniorPlayerViewModel, Senior>();
            CreateMap<Senior, SeniorPlayerViewModel>();
                


        }



        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperProfile>());
        }


    }
}
