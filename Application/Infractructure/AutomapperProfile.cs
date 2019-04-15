using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Infractructure
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {

        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m=>m.AddProfile<AutomapperProfile>());
        }
    }
}
