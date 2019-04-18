using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class GuardianViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public DateTime? Signature { get; set; }
        public AddressViewModel Address { get; set; }
    }
}
