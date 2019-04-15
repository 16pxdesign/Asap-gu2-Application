using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Business;
using Application.Business.Interfaces;
using Application.Domain;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Models.ViewModels;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private IAddressBusiness _adr;
        public HomeController(IAddressBusiness adr)
        {
            _adr = adr;

        }
        public IActionResult Index()
        {
            var addressViewModel = new AddressViewModel { City = "Szczecin", Flat = "1", Street = "Lochee" };
            var addressDomain = new AddressDomain();
            AutoMapper.Mapper.Map(addressViewModel, addressDomain);

            _adr.Add(addressDomain);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}
