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
                db.Database.GetDbConnection().CreateCommand().CommandText = "PRAGMA foreign_keys=ON";
                var member = new Member {SRU = "05", Type = MemberType.Senior, 
                    Player = new Player
                    {
                        Junior = new Junior
                        {
                         Guardians = new List<Guardian> {new Guardian()}
                        }
                    },
                    Address = new Address()
                    
                };
                db.Members.Add(member);
                db.SaveChanges();
            }

            return View();
        }

        public IActionResult Del()
        {
            using (var db = new DatabaseModel())
            {
                var member = db.Members.Find("05");
                
                db.Members.Remove(member);
                db.SaveChanges();
            }
            
            return View();
        }
        

        public IActionResult Contact()
        {
            using (var db = new DatabaseModel())
            {
                var member = new Member {SRU = "05", Type = MemberType.Junior, 
                    // Address = new Address(), 
                   Player = new Player
                   {
                       Position = PlayerPosition.Hooker
                   }
                    
                };
                db.Members.Add(member);
                db.SaveChanges();
            }
 
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