using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;

namespace Application.Models
{
    public class Member
    {
        //[Key]
        public string SRU { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        //[ForeignKey("Address")]
        public int AddressNO { get; set; }
        public virtual Address Address { get; set; }
        public virtual Player Player { get; set; }
    }
}