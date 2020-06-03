using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:" );
            int num = Console.ReadLine();
            Console.WriteLine(IsPrime(num));
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n == 3)
                return true;

            bool isEven;

            if (n % 2 == 0)
                isEven = true;
            else
                isEven = false;

            int counter = 3;
            double max = Math.Sqrt(n);
            bool result = true;

            if (isEven == false)
            {
                do
                {
                    if (n % counter == 0)
                        result = false;

                    counter++;

                } while (counter <= max);
            }
            else
            {
                result = false;
            }

            return result;
        }

    }
}
