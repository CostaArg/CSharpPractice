using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is: " + name + " and you are " + age + " years old");
        }
    }
}