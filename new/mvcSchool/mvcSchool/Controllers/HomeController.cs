using mvcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcSchool.Controllers
{
    public class HomeController : Controller
    {
        private MyDatabase db = new MyDatabase();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Course()
        {
            return View(db.Courses.ToList());
        }

        public ActionResult Trainer()
        {
            return View(db.Trainers.ToList());
        }

        public ActionResult Assignment()
        {
            return View(db.Assignments.ToList());
        }
    }
}