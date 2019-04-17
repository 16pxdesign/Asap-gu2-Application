using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class TestController : Controller
    {
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
        public string Index(Test model)
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
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

            return sb.ToString();
            
        }
    }
}