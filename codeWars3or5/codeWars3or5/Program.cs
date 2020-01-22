using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWars3or5
{
    class Program
    {
        static void Main(string[] args)
        {
           int kati = Kata.Solution(10);
            Console.WriteLine(kati);
        }

        public static class Kata
        {
            public static int Solution(int value)
            {
                // Magic Happens
                int counter = 0;
                int sum = 0;

                do
                {
                    if (counter % 3 == 0 || counter % 5 == 0)
                    {
                        sum = sum + counter;
                    }
                    counter++;
                } while (counter < value);

                return sum;
            }
        }
    }
}
