using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Console.WriteLine(h1.Age);

            Human h2 = new Human(2, 30);
            Console.WriteLine(h2.Age);

            Human h3 = new Human("Hector"); //an balw tous allous constructors private, tote fenete mono autos o constructor kai pirodotei tous allous (encapsulation + chaining constructors)
            Console.WriteLine(h3.Age);
        }
    }

    class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Human()
        {
            Age = 30;
            Name = "O kanenas";
        }

        public Human(int a, int b)
        {
            Age = a + b;
            Name = "Kalimera";
        }

        public Human(string kati) :this(9, 10)
        {

        }
    }
}
