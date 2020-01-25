using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsCountDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = Kata.Divisors(54);
            Console.WriteLine(n);
        }
    }

    public class Kata
    {
        public static int Divisors(int n)
        {
            int divisor = 1, counter = 1;

            if (n == 0)
                return 0;

                do
                {
                    if (n % divisor == 0)
                        counter++;

                    divisor++;
                } while (divisor != n);

            return counter;
        }
    }


}