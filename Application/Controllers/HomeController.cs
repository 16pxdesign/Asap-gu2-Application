using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            using (var db = new DatabaseModel())
            {
                var member = new Member {SRU = "03", Type = MemberType.Senior, Player = new Player {Position = PlayerPosition.Hooker, Senior = new Senior{Kin = "huj"}}};
                db.Members.Add(member);
                db.SaveChanges();
            }

            return View();
        }

        public IActionResult Contact()
        {
/*
            using (var db = new DatabaseModel())
            {
                var members = db.Members.ToList();
                            foreach (var member in members)
                            {
                                Console.WriteLine($"{member.SRU} {member.Name} {member.GetType().Name}");
                            }
                var firstOrDefault = db.Members.FirstOrDefault(b => b.SRU == "003");
                //firstOrDefault = new Member() {SRU = firstOrDefault.SRU, Name = firstOrDefault.Name};
                
                Console.WriteLine(firstOrDefault.GetType());

                db.Members.Remove(firstOrDefault);
                //db.Members.Update(firstOrDefault);
                db.SaveChanges();
            } 
        */
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}