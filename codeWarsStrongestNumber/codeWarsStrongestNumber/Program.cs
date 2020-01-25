using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsStrongestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = StrongestEvenNumber.strongestEven(5, 10);
            Console.WriteLine(number);
        }
    }

    public class StrongestEvenNumber
    {
        public static int strongestEven(int n, int m)
        {
            double number1a = n;
            double number1b = n;
            int counter1 = 0;

            double number2a = m;
            double number2b = m;
            int counter2 = 0;

            do
            {
                number1a /= 2;
                number1b /= 2;

                number1a = Math.Truncate(number1a);

                if (number1a == number1b)
                    counter1++;
                else
                    break;


            } while (true);

            do
            {
                number2a /= 2;
                number2b /= 2;

                number2a = Math.Truncate(number2a);

                if (number2a == number2b)
                    counter2++;
                else
                    break;

            } while (true);

            if (counter1 > counter2)
                return n;
            else if (counter1 < counter2)
                return m;
            else
            {
                if (n > m)
                    return m;
                else
                    return n;
            }
        }
    }
}

