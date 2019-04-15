using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.ViewModels
{
    public class JuniorPlayerViewModel
    {
        public PlayerPosition Position { get; set; }
        public List<HealthIssueViewModel> HealthIssues { get; set; }
        public List<GuardianViewModel> Guardians { get; set; }
        public DoctorViewModel Doctor { get; set; }
        


    }
}
