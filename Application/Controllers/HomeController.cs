using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Repo.Contracts;
using System.Dynamic;
using Application.Data.Models;
using Application.Repo;
using Application.ViewModels;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            var address = new Address { City = "szczecin" };
            var addressVm = new AddressViewModel();
            AutoMapper.Mapper.Map(address, addressVm);


            ViewBag.Address = addressVm;

            //this._unitOfWork.AddressRepository.Insert(address);
            //await _unitOfWork.Commit();
            var test = new Test();
            test.address = addressVm;
            return View(test);
        }

        public IActionResult Member()
        {
            _unitOfWork.MemberRepositories.Add(new Member());
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
