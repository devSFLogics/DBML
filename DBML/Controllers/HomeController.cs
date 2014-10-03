using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using DBML.Models;

namespace DBML.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseDataContext db;
        public HomeController()
        {
            db = new DataBaseDataContext();
        }

        public ActionResult Index()
        {
            
            return View();
        }       

        public ActionResult Register()
        {
            User model = new User();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            try
            {
                db.Users.InsertOnSubmit(model);
                db.SubmitChanges();
                return RedirectToAction("Login");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User u)
        {
            if (ModelState.IsValid)
            {
                var v = db.Users.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
                if (v != null)
                {
                    FormsAuthentication.SetAuthCookie(u.UserName, false);
                    //Session["LogedUserId"] = v.UserId.ToString();
                    // Session["LogedUserName"] = v.UserName.ToString();
                    //return RedirectToAction("AfterLogin");
                    ViewBag.Message = "Successfully Logged in..!";
                }
            }
            return View(u);
        }

        [Authorize]
        public ActionResult AfterLogin(User u)
        {
            //FormsAuthentication.SetAuthCookie(u.UserName, false);
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
