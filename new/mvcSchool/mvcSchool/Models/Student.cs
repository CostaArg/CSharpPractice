using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcSchool.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int TuitionFees { get; set; }
    }
}