using System;

namespace Application.Models
{
    public class Member
    {
        //Primary
        public string SRU { get; set; }

        //Properties
        public MemberType Type  { get; set; }
        public string Name { get; set; }  
        public string Email { get; set; }
        public bool Active { get; set; }

        //Relations
        public virtual Player Player { get; set; }
        public virtual Address Address { get; set; }

  
    }
}