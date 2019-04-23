using System;

namespace Application.Data.Models
{
    public class Address
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Flat { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
  
        //Relations
    }
}