using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBML.Models;

namespace DBML.Controllers
{
    public class CourseController : Controller
    {
        private DataBaseDataContext db;

        public CourseController()
        {
            db = new DataBaseDataContext();
        }

        public ActionResult Index()
        {
            List<UserCourse> CourseList = new List<UserCourse>();
            var query = from course in db.UserCourses
                        join User in db.Users
                        on course.UserId equals User.Id
                        select course;
            CourseList = query.ToList();
            return View();
        }

        public ActionResult AddCourse()
        {
            UserCourse model = new UserCourse();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCourse(UserCourse model)
        {
            try
            {
                db.UserCourses.InsertOnSubmit(model);
                db.SubmitChanges();
                return RedirectToAction("index");
            }
            catch
            {
                return View(model);
            }
        }

    }
}
