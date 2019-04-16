using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
                .ForPath(d => d.Player.Junior, o =>
                {
                    o.MapFrom(s=> Mapper.Map<JuniorPlayerViewModel, Junior>(s.JuniorPlayer));
                })
                .ForPath(d => d.Player.Senior, o =>
                {
                    o.MapFrom(s => Mapper.Map<SeniorPlayerViewModel, Senior>(s.SeniorPlayer));
                })
                ;

            CreateMap<PlayerViewModel, Player>();
            CreateMap<JuniorPlayerViewModel, Junior>();
            CreateMap<SeniorPlayerViewModel, Senior>();
                

            /*CreateMap<MemberViewModel, Member>()
                .ForPath(d => d.Player.Junior, o =>
                {
                    o.Condition(s => s.Source.Type == MemberType.Junior);
                    o.MapFrom(s => new Junior()
                    {
                        SRU = s.SRU,
                        Guardians = Mapper.Map<List<GuardianViewModel>, List<Guardian>>(s.JuniorPlayer.Guardians)
                    });
                })
                .ForPath(d => d.Player.Senior, o =>
                {
                    o.Condition(s => s.Source.Type == MemberType.Senior);
                    o.MapFrom(s => new Senior()
                    {
                        SRU = s.SRU,
                        //Guardians = Mapper.Map<List<GuardianViewModel>, List<Guardian>>(s.JuniorPlayer.Guardians)
                    });
                    
                })
                .ForMember(d => d.Player, o =>
                    {
                        o.PreCondition(s=>s.Type != MemberType.Senior);
                        o.MapFrom(s => new Player()
                        {
                            SRU = s.SRU,
                            Position = s.JuniorPlayer.Position,
                            Doctor = Mapper.Map<DoctorViewModel, Doctor>(s.JuniorPlayer.Doctor)

                        });
                    })
                .ForMember(d => d.Player, o =>
                {
                    o.PreCondition(s => s.Type == MemberType.Senior);
                    o.MapFrom(s => new Player()
                    {
                        SRU = s.SRU,
                        Position = s.SeniorPlayer.Position,
                        Doctor = Mapper.Map<DoctorViewModel, Doctor>(s.SeniorPlayer.Doctor)

                    });
                })
                ;*/




            /*s => s.SeniorPlayer ==null ? new Player() : new Player()
                {
                    SRU = s.SRU,
                    Position = s.SeniorPlayer.Position,
                    Doctor = Mapper.Map<DoctorViewModel, Doctor>(s.SeniorPlayer.Doctor)

                })*/


            /*
             *
             * .ForMember(d => d.Player, o => o.MapFrom(s => new Player()
                {
                    SRU = s.SRU,
                    Position = s.JuniorPlayer.Position,
                    Doctor = Mapper.Map<DoctorViewModel,Doctor>(s.JuniorPlayer.Doctor)
                    
                }))
             */






        }

        public static void MapFromIfNotNull<TSource, TDestination, TProperty>(IMemberConfigurationExpression<TSource, TDestination, TProperty> map,
            Expression<Func<TSource, object>> selector)
        {
            var function = selector.Compile();
            map.Condition(source => function(source) != null);
            map.MapFrom(selector);
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperProfile>());
        }


    }
}
