using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AddressViewModel
    {
        [Required]
        public string Flat { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string City { get; set; }

    }
}
