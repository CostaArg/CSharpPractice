using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
           bool something = Kata.IsPrime(71);
            Console.WriteLine(something);
        }

        public static class Kata
        {
            public static bool IsPrime(int n)
            {
                // TODO

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
                bool something = true;

                if (isEven == false)
                {
                    do
                    {
                        if (n % counter == 0)
                        {
                            something = false;
                        }

                        counter++;

                    } while (counter <= max);
                }
                else
                {
                    something = false;
                }

                return something;
            }
        }
    }
}
