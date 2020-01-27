using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSumOddTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 5;
            long result = Kata.rowSumOddNumbers(number);
            Console.WriteLine(result);
        }
    }

    public static class Kata
    {
        public static long rowSumOddNumbers(long n)
        {
            int counter = 1;
            int counter2 = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = 0;

                for (int j = 0; j < counter2; j++)
                {
                    sum += counter;
                    Console.Write(counter + " ");
                    counter += 2;
                }

                Console.WriteLine();
                counter2++;
            }

            Console.WriteLine("Sum is: " + sum);

            return sum;
        }
    }
}
