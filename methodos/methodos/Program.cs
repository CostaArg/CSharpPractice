using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodos
{
    class Program
    {

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Diairesh(int x, int y)
        {
            return x / y;
        }

        static int Pollaplasiasmos(int x, int y)
        {
            return x * y;
        }

        static int Afairesh(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            string prwtos, deuteros;

            Console.WriteLine("Enter your first number: ");
            prwtos = Console.ReadLine();
            Console.WriteLine("Enter your second number: ");
            deuteros = Console.ReadLine();

            a = Convert.ToInt32(prwtos);
            b = Convert.ToInt32(deuteros);

            Console.WriteLine("The sum between the two numbers is: ");
            Console.WriteLine(Sum(a, b));

            Console.WriteLine("The division between the two numbers is: ");
            Console.WriteLine(Diairesh(a, b));

            Console.WriteLine("The multiplication between the two numbers is: ");
            Console.WriteLine(Pollaplasiasmos(a, b));

            Console.WriteLine("The subtraction between the two numbers is: ");
            Console.WriteLine(Afairesh(a, b));
        }
    }
}
