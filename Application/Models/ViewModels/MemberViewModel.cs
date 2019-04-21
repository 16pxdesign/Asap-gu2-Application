using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.Models
{
    public class MemberViewModel
    {
        public MemberViewModel()
        {
            Player = new PlayerViewModel();
        }

        [Required]
        public string SRU { get; set; }
        public MemberType Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public AddressViewModel Address { get; set; }
        public PlayerViewModel Player { get; set; }


    }
}
