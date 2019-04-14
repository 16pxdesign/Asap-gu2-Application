using System;

namespace Application.Repository.Models
{
    public class Guardian
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public DateTime? Signature { get; set; }

        //Relations
        public virtual Junior Junior { get; set; }
    }
}