using Caesar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caesar.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //public ActionResult Index(int id)
        //{
        //    id = 500;
        //    string str = id.ToString();
        //    return Content(str);
        //}

        //public ActionResult Takis(int id)
        //{
        //    return Content("Kalimera" + id.ToString());
        //}

        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student() { Id = 1, FirstName = "Hector" };
            Student s2 = new Student() { Id = 1, FirstName = "Hector" };
            Student s3 = new Student() { Id = 1, FirstName = "Hector" };
            Student s4 = new Student() { Id = 1, FirstName = "Hector" };
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);

            ViewBag.Students = students;
            return View();
            //kanonika View(students); kai meta @model IEnumerable<Ceasar.Models.Student> kai meta @foreach sthn lista Model
        }
    }
}