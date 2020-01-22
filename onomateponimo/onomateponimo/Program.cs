using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anthropos;

namespace onomateponimo
{
    class Program
    {
        static string getFirstname()
        {
            string firstname = "George";
            return firstname;
        }

        static string getLastname()
        {
            string lastname = "Papadopoulos";
                return lastname;
        }

        static string getFullname()
        {
            string fullname = getFirstname() + " " + getLastname();
            return fullname;
        }
        static void Main(string[] args)
        {
            //procedural
            string firstname = "George";
            string lastname = "Papadopoulos";
            string fullname = firstname + " " + lastname;
            Console.WriteLine("Your fullname is: " + fullname);

            //methods
            Console.WriteLine("Your fullname is: " + getFullname());

            //prospa8w me object oriented programming
            Person.firstName = "Peter";
            Person.lastName = "Parker";
            Console.WriteLine("Your fullname is: " + Person.fullName());

            //pragmatiko object oriented programming
            User user = new User();
            user.firstName = "Kostis";
            user.lastName = "Palamas";
            Console.WriteLine("Your fullname is: " + user.fullName());

        }
    }
}
    