using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodosMeRead
{
    class Program
    {
        static int getNumber(int x, y)
        {
            string dwse;
            int arithmos;

            Console.WriteLine("Enter your number: ");
            dwse = Console.ReadLine();

            arithmos = Convert.ToInt32(dwse);

            return arithmos;
        }
        static void Main(string[] args)
        {
            int a;
            int b;

            int x = getNumber();
            int y = getNumber();

            Console.WriteLine("Your numbers are: " + x + " " + y);
        }
    }
}
