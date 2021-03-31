using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kaubaladu.Models;
using System.Web.Security;

namespace Kaubaladu.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            using (var context = new KaubaladuEntities())
            {
                bool isValid = context.Users.Any(x => x.Username == model.Username && x.Password == model.Password);
                if(isValid)
                {
                    if(model.Username == "admin")
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, false);
                        return RedirectToAction("Index", "Users");
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, false);
                        return RedirectToAction("Index", "Goods");
                    }
                }

                ModelState.AddModelError("","Invalid username and password");
            }
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User model)
        {
            using(var context = new KaubaladuEntities())
            {
                context.Users.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}