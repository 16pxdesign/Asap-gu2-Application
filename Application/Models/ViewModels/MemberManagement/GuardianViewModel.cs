using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class GuardianViewModel
    {
        public GuardianViewModel()
        {
            Signature = DateTime.Today;
        }
        
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required] 
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)] 
        [Phone] 
        public string Phone { get; set; }
        public string Relationship { get; set; }
        [DataType(DataType.Date)] 
        public DateTime Signature { get; set; }
        public AddressViewModel Address { get; set; }
    }
}