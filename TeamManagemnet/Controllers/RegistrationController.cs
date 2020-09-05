using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamManagemnet.Models;

namespace TeamManagemnet.Controllers
{
    public class RegistrationController : Controller
    {
        UserDbContext Db = new UserDbContext();
       
        public ActionResult Register()
        {
            ViewData["Role"] = Db.Roles;
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                Db.Users.Add(user);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some error occured");

            }
            return View(user);
        }
    }
}