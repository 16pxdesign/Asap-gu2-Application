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
        private readonly static List<Contact> Contacts = new List<Contact>();

        public IActionResult Index()
        {
          /*  TempData.TryGetValue("data", out object value);
            var data = value as string ?? "";
            List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(data) ?? new List<Contact>();
            string json = JsonConvert.SerializeObject(list);         
            TempData["data"] = json;
*/
           
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax)
            {

                return PartialView("_Table", Contacts);
            }
      
            
            return View(Contacts);
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
                
                Contacts.Add(model);

                TempData.TryGetValue("data", out object value);
                var data = value as string ?? "";
                List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(data) ?? new List<Contact>();
                list.Add(model);
                string json = JsonConvert.SerializeObject(list);         
                TempData["data"] = json;
                    

                ///NOTIFICATION PART
                CreateNotification("Contact saved!");
            }

            return PartialView("_ContactModalPartial", model);
        }

        ///NOTIFICATION PART
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