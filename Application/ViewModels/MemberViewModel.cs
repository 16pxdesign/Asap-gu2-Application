using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.ViewModels
{
    public class MemberViewModel
    {

        public string SRU { get; set; }
        public MemberType Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public AddressViewModel Address { get; set; }
        public PlayerViewModel Player { get; set; }
        public JuniorPlayerViewModel JuniorPlayer { get; set; }
        public SeniorPlayerViewModel SeniorPlayer { get; set; }

    }
}
