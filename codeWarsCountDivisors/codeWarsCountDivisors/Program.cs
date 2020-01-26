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
        }
    }

    public class Kata
    {
        public static int Divisors(int n)
        {
            int divisor = 1, counter = 1;

            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            do
            {
                if (n % divisor == 0)
                    counter++;

                divisor++;
            } while (divisor <= n / 2);

            return counter;
        }
    }
}
