using System;
using System.Collections.Generic;
using System.Text;
using Application.Repo;
using Application.Repo.Contracts;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class TestController : Controller
    {
        
        private readonly UnitOfWork _unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
        }
        
        public IActionResult Index()
        {
            var test = new Test();
            test.Address = new List<AddressViewModel>();
            test.Address.Add(new AddressViewModel()
            {
                City = "szczecin",
                Flat = "100",
                Postcode = "DD23AD",
                Street = "High"
            });
            test.Address.Add(new AddressViewModel()
            {
                City = "szczecin",
                Flat = "200",
                Postcode = "DD23AD",
                Street = "High"
            });
            test.Address.Add(new AddressViewModel()
            {
                City = "szczecin",
                Flat = "300",
                Postcode = "DD23AD",
                Street = "High"
            });
            
           
            return View(test);
        }

        [HttpPost]
        public IActionResult Index(Test model)
        {
            var sb = new StringBuilder();
            try
            {
                sb.AppendFormat("Author : {0}", model.Name);
                sb.AppendLine("<br />");
                sb.AppendLine("--------------------------------");
                sb.AppendLine("<br />");
                foreach (var item in model.Address)
                {
                    sb.AppendFormat("Title : {0} | Published Date : {1}", item.Flat, item.Street);
                    sb.AppendLine("<br />");
                }

                
                    foreach (var item in model.Health)
                    {
                        sb.AppendFormat("Title : {0} | Published Date : {1}", item.Date, item.Name);
                        sb.AppendLine("<br />");
                    
                    
               
               
                    
                }
                
              
                
            }
            catch (Exception ex)
            {
                throw ex;
            }




            return View(model);
        }

        public string Index2()
        {
            var findBySru = _unitOfWork.MemberRepositories.FindBySRU("123Aleksy Ryszard Ruszala");
            
            return null;
        }
    }
}