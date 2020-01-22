using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anthropos
{
    static class Person
    {
        public static string firstName;
        public static string lastName;
        public static string fullName()
        {
            return firstName + " " + lastName;
        }
    }
}
