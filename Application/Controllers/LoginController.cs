using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginViewModel _login;

        public LoginController()
        {
            _login = new LoginViewModel() { Password = "123456" };
        }
       
        public IActionResult Index()
        {
            
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password.Equals(_login.Password))
                {
                    HttpContext.Session.SetString("Auth", "login");
                    return RedirectToAction("Index", "Index", null);

                }
                
                ModelState.AddModelError("Password","Wrong password");

                
            }

            return View();
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Auth");
            return RedirectToAction("Index");
        }
    }
}