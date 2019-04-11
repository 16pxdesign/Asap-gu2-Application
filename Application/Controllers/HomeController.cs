using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            using (var db = new DatabaseModel())
            {
                var firstOrDefault = db.Members.FirstOrDefault(c => c.SRU == "001");
                db.Remove(firstOrDefault);
              
              /*db.Members.Add(new Member()
              {
                  SRU = "001",
                  Name = "Frank",
                  Player = new Player()
                  {
                        
                  }
                 ,Address = new Address()
                    
              });*/
                
                db.SaveChanges();

            }
            /* DatabaseModel db = new DatabaseModel();
             var val = db.Members.FirstOrDefault(b => b.Name == "Frank"); 

             var x = new Player(val);

             db.Players.Update(x);

             // Save changes in database
             db.SaveChanges();*/

            /*DatabaseModel db = new DatabaseModel();
            var x = new Player();
           x.Doctor = new Doctor();
           x.Name = "Kurwa";
           x.SRU = "123";
           db.Members.Add(x);
           db.SaveChanges();*/

            /*  DatabaseModel db = new DatabaseModel();
              Player sel = db.Players
                  .FirstOrDefault(b => b.Name == "Kurwa");

              db.Members.Update(sel);
              db.SaveChanges();*/


    /*        DatabaseModel db = new DatabaseModel();
            var val = db.Members
                .FirstOrDefault(b => b.Name == "Yordan");
            db.Entry(val).State = EntityState.Detached;
            var val2 = new Player(val);
            val2.Name = "Frank";
            db.Members.Update(val2);
            db.SaveChanges();*/

            return View();
        }

        public IActionResult About()
        {
            /*
            using (var db = new DatabaseModel())
            {
                db.Database.EnsureCreated();
                db.Members.Add(new Member
                {
                    SRU = "001",
                    Name = "Alex",
                    Phone = "0700"
                });
                db.Members.Add(new Player
                {
                    SRU = "002",
                    Name = "Michal",
                    Position = new PlayerPosition{Positon = "Hooker"}
                });
                db.Members.Add(new Senior()
                {
                    SRU = "003",
                    Name = "Wars",
                    Position = new PlayerPosition{Positon = "Kick"},
                    Kin = new Kin(){Name = "Kelly"}
                });
                int changed = db.SaveChanges();
                Debug.WriteLine($"changed {changed} records");
                
            }
            Debug.WriteLine("Hello, world!");
*/

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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
