using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcSchool.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
    }
}