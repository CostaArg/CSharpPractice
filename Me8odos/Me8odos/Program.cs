using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me8odos
{
    class Program
    {
        static string getName(string name)
        {

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            return name;
        }

        static int getAge(string userAge, int age)
        {

            Console.WriteLine("Enter age: ");
            userAge = Console.ReadLine();

            age = int.Parse(userAge);

            return age;
        }

        static void Main(string[] args)
        {
            Program kati = new Program();

            string name;
            int age;

            name = kati.getName();
            age = kati.getAge();

            Console.WriteLine("Your name is: " + name + " and you are " + age + " years old");
        }
    }
}