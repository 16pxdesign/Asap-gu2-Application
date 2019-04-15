using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

            CreateMap<Address, AddressViewModel>();
            CreateMap<AddressViewModel, Address>();
            CreateMap<Member, MemberViewModel>();

            CreateMap<MemberViewModel, Member>()
                .ForMember(d => d.Player, o => o.MapFrom(s => new Player()
                {
                    SRU = s.SRU,
                    Position = s.JuniorPlayer.Position,
                    Doctor = Mapper.Map<DoctorViewModel,Doctor>(s.JuniorPlayer.Doctor)
                    
                }))
                .ForPath(d => d.Player.Junior, o => o.MapFrom(s => new Junior()
                {
                    SRU = s.SRU,
                    Guardians = Mapper.Map<List<GuardianViewModel>, List<Guardian>>(s.JuniorPlayer.Guardians)
                }));








        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperProfile>());
        }


    }
}
