using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TeamManagemnet.Models;

namespace TeamManagemnet.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(User user,string ReturnUrl)
        {
            if(IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View(user);
            }
            
        }
        
       
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn");
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        public bool IsValid(User user)
        {
            return (user.Password == "team1234");
        }
    }

}