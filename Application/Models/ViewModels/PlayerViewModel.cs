using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.Models
{
    public class PlayerViewModel
    {
        public PlayerViewModel()
        {
            Position = null;
            HealthIssues = new List<HealthIssueViewModel>();
            Junior = new JuniorViewModel();
        }

        public PlayerPosition? Position { get; set; }
        public DoctorViewModel Doctor { get; set; }
        public List<HealthIssueViewModel> HealthIssues { get; set; }
        public JuniorViewModel Junior { get; set; }
        public SeniorViewModel Senior { get; set; }

    }
}
