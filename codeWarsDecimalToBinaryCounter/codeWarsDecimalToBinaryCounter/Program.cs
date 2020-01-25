using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDecimalToBinaryCounter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int CountBits(int n)
        {
            double number = Convert.ToDouble(n);
            int counter = 0;
            double power;
            int binaryCounter = 0;

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
                    binaryCounter++;
                }
                else
                {
                    counter++;
                }

            } while (number != 0);

            return binaryCounter;
        }
    }
}
