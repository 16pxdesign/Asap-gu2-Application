using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.Models
{
    [Serializable]
    public class JuniorViewModel
    {
        public JuniorViewModel()
        {
            Guardians = new List<GuardianViewModel>();
        }

        public List<GuardianViewModel> Guardians { get; set; }

        


    }
}
