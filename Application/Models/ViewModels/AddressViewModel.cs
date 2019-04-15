using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class AddressViewModel
    {
        public string Flat { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
    }
}
