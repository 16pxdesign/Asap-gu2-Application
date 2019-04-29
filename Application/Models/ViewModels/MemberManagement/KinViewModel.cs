using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class KinViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)] 
        [Phone] 
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public AddressViewModel Address { get; set; }
    }
}
