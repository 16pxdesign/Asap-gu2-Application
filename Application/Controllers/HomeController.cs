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
            var member = new Member();
            var memberViewModel = new MemberViewModel();
            memberViewModel.SRU = "3001";
            memberViewModel.Name = "Frank";
            memberViewModel.Address = new AddressViewModel();
            memberViewModel.Player = new PlayerViewModel();
            memberViewModel.JuniorPlayer = new JuniorPlayerViewModel();
            memberViewModel.Player.Position = PlayerPosition.Bolt;
            memberViewModel.Player.Doctor = new DoctorViewModel();
            memberViewModel.Player.Doctor.Address = new AddressViewModel();
            memberViewModel.JuniorPlayer.Guardians = new List<GuardianViewModel>();
            memberViewModel.JuniorPlayer.Guardians.Add(new GuardianViewModel(){ Address = new AddressViewModel() });
            memberViewModel.JuniorPlayer.Guardians.Add(new GuardianViewModel(){Address = new AddressViewModel()});
            memberViewModel.Player.HealthIssues = new List<HealthIssueViewModel>();
            memberViewModel.Player.HealthIssues.Add(new HealthIssueViewModel());
            memberViewModel.Player.HealthIssues.Add(new HealthIssueViewModel());
            
            AutoMapper.Mapper.Map(memberViewModel, member );
            _unitOfWork.MemberRepositories.Add(member);
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
