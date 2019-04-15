using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain
{
    public class AddressDomain
    {
        public int Id { get; set; }
        public string Flat { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
    }
}
