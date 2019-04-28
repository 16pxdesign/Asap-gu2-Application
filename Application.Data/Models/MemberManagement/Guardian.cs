using System;

namespace Application.Data.Models
{
    public class Guardian
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public DateTime Signature { get; set; }

        public string JuniorId { get; set; }

        //Relations
        public virtual Junior Junior { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
    }
}