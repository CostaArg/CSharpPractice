using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5dekAsk6
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;

            Console.WriteLine("Give the first value: ");
            string firstValue = Console.ReadLine();
            Console.WriteLine("Give the second value: ");
            string secondValue = Console.ReadLine();

            temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
    }
}
