using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> AddOne = Kata.Add(1);
            Console.WriteLine(AddOne(3));
        }
    }

    public static class Kata
    {
        public static Func<double, double> Add(double n)
        {
            return m => m + n;
        }
    }
}
