using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CurrencyFreelanceProj.Controllers
{
    
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(string uname,string pass)
        {
            string username = "max";
            string password = "max123";
            if (uname == username && password == pass)
            {
                Session["userName"] = username;
                FormsAuthentication.SetAuthCookie(uname, false);
                return RedirectToAction("Index", "CurrencyHome");
            }
            else
            {
                ModelState.AddModelError("customError", "invalid username or password");
                return RedirectToAction("login", "Account");
            }
                


            
        }
    }
}