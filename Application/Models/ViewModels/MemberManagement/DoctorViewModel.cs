﻿using System;
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
        public string Surname { get; set; }
        public string Phone { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
