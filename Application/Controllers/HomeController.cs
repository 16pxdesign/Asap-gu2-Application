using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            List<Contact> list = new List<Contact>();
            
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                TempData.TryGetValue("data", out object value);
                var data = value as string ?? "";
                list = JsonConvert.DeserializeObject<List<Contact>>(data) ?? new List<Contact>();
                TempData["data"] = JsonConvert.SerializeObject(list);         
                

                return PartialView("_Table", list);
            }
      
           
            TempData["data"] = JsonConvert.SerializeObject(list);         
            
            
            return View(list);
        }

        public IActionResult Contact()
        {
            var model = new Contact { };

            return PartialView("_ContactModalPartial", model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                TempData.TryGetValue("data", out object value);
                var data = value as string ?? "";
                List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(data) ?? new List<Contact>();
                list.Add(model);
                string json = JsonConvert.SerializeObject(list);         
                TempData["data"] = json;
            }

            return PartialView("_ContactModalPartial", model);
        }

        [NonAction]
        private void CreateNotification(string message)
        {
            TempData.TryGetValue("Notifications", out object value);
            var notifications = value as List<string> ?? new List<string>();
            notifications.Add(message);
            TempData["Notifications"] = notifications; 
        }

        public IActionResult Notifications()
        {
            TempData.TryGetValue("Notifications", out object value);
            var notifications = value as IEnumerable<string> ?? Enumerable.Empty<string>();
            return PartialView("_NotificationsPartial", notifications);
        }
    }
    
}