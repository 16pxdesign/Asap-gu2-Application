using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Business;
using Application.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository repository)
        {

        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}
