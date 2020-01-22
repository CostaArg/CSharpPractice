using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDivisables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 10 };
            Kata.DivisibleBy(numbers, 5);
        }


    }


public class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int> Divisables = new List<int>();

            foreach (var number in numbers)
            {
                if (number % divisor == 0)
                {
                    Divisables.Add(number);
                }
            }

            int[] pinakas = Divisables.ToArray();

            return pinakas;
        }
    }
}
