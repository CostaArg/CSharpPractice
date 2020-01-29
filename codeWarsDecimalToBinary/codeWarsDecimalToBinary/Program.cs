//unfinished

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.ToBinary(5);
        }
    }

    public static class Kata
    {
        public static int ToBinary(int n)
        {
            double number = Convert.ToDouble(n);
            int counter = 0;
            double power;
            string binaryString = null;

            if (number == 0)
                return 0;

            do
            {
                power = Math.Pow(2, counter);

                if (power > number)
                {
                    counter--;
                    power = Math.Pow(2, counter);
                    number %= power;
                    counter = 0;
                }
                else
                {
                    counter++;
                }

            } while (number != 0);

            Console.WriteLine(binaryString);

            return 0;
        }
    }


}
