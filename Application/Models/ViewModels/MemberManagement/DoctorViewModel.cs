using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models;

namespace Application.Models
{
    public class DoctorViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)] 
        [Phone] 
        public string Phone { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
