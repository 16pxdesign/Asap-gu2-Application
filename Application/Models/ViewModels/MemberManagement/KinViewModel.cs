﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/**
 * 
 * name         :   KinViewModel.cs
 * author       :   Aleksy Ruszala
 * date         :   29/04/2019
 *
 * */
namespace Application.Models
{
    /// <summary>
    /// This class representing view model for seniors kin
    /// </summary>
    public class KinViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)] 
        [Phone] 
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public AddressViewModel Address { get; set; }
    }
}
