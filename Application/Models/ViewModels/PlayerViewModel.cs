using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.Models
{
    public class PlayerViewModel
    {

        public PlayerPosition Position { get; set; }
        public DoctorViewModel Doctor { get; set; }
        public List<HealthIssueViewModel> HealthIssues { get; set; }
        public List<Contact> Contacts { get; set; }
        public JuniorPlayerViewModel JuniorPlayer { get; set; }
        public SeniorPlayerViewModel SeniorPlayer { get; set; }

    }
}
