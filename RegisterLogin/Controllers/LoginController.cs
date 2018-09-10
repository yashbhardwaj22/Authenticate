using Microsoft.AspNetCore.Mvc;
using RegisterLogin.DAL;
using RegisterLogin.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegisterLogin.Controllers
{

    public class LoginController : Controller
    {
        private DBOperations dbOperations = new DBOperations();
        

        public IActionResult Index()
        {            
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Register(Login newUser)
        //{
        //    dbOperations.Register(newUser);
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public IActionResult Index(LoginModel login)
        {
            List<Login> allUser = dbOperations.GetAllStudent();
            Login user = allUser.Where(x => x.UserEmail == login.UserEmail && x.UserPassword == login.UserPassword).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction("Dashboard","Login",user);
            }
            return RedirectToAction("Index");
        }
       
        public IActionResult Dashboard(Login user)
        {
            if (user.UserEmail != null)
            {
                return View(user);
            }
            return RedirectToAction("Index");
        }
    }
}