using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View("~/Views/Partial/AddOrEdit/Member.cshtml");
        }
    }
}