using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Domain;
using Application.Models.ViewModels;

namespace Application.Infrastructure
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AddressViewModel, AddressDomain>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m=>m.AddProfile<AutomapperProfile>());
        }
    }
}
