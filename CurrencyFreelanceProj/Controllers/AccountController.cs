using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                return RedirectToAction("Index", "CurrencyHome");
            }
            else
                return RedirectToAction("login", "Account");


            
        }
    }
}