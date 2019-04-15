using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.ViewModels;

namespace Application.Frameworks
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Address, AddressViewModel>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperProfile>());
        }


    }
}
