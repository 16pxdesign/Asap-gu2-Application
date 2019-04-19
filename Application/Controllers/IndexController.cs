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

namespace Application.Controllers
{
    public class IndexController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly static List<HealthIssueViewModel> list = new List<HealthIssueViewModel>();



        public IndexController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }

        public IActionResult Index(object modelx)
        {
            if (modelx == null)
            {
                
            }
            var model = new MemberViewModel
            {
                Player = new PlayerViewModel
                {
                    HealthIssues = new List<HealthIssueViewModel>()
                }
            };

           
            
            
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax)
            {
                return PartialView("_HealthTable", list);
            }
            
            return View(model);
        }

        
        public IActionResult AddHealth()
        {
            var model = new HealthIssueViewModel();

            return PartialView("_HealthAddForm", model);
        }
        
        [HttpPost]
        public IActionResult AddHealth(HealthIssueViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO:Save to db here
                
                list.Add(model);

                
            }

            return PartialView("_HealthAddForm", model);
        }
        
        
    
       
        public IActionResult Member()
        {
            /*var member = new Member();
            var memberViewModel = new MemberViewModel();
            memberViewModel.SRU = "4002";
            memberViewModel.Name = "Frank";
            memberViewModel.Address = new AddressViewModel();
            memberViewModel.Player = new PlayerViewModel();
            memberViewModel.JuniorPlayer = new JuniorPlayerViewModel();
            memberViewModel.Player.Position = PlayerPosition.TightheadProp;
            memberViewModel.Player.Doctor = new DoctorViewModel();
            memberViewModel.Player.Doctor.Address = new AddressViewModel();
            memberViewModel.JuniorPlayer.Guardians = new List<GuardianViewModel>();
            memberViewModel.JuniorPlayer.Guardians.Add(new GuardianViewModel(){ Address = new AddressViewModel() });
            memberViewModel.JuniorPlayer.Guardians.Add(new GuardianViewModel(){Address = new AddressViewModel()});
            memberViewModel.Player.HealthIssues = new List<HealthIssueViewModel>();
            memberViewModel.Player.HealthIssues.Add(new HealthIssueViewModel());
            memberViewModel.Player.HealthIssues.Add(new HealthIssueViewModel());
            
            AutoMapper.Mapper.Map(memberViewModel, member );
            _unitOfWork.MemberRepositories.Add(member);*/
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
