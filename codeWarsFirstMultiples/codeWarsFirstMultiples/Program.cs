using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsFirstMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Kata.Multiples(3, 0.0);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Kata
    {
        public static double[] Multiples(int m, double n)
        {
            List<double> numbers = new List<double>();
            double multi = Convert.ToDouble(m);
            double number = n;
            int counter = 0;

            if (number > 0)
            {
                do
                {
                    numbers.Add(number);
                    number += n;
                } while (number <= multi * n);
            }
            else if (number < 0)
            {
                do
                {
                    numbers.Add(number);
                    number += n;
                } while (number >= multi * n);
            }
            else
            {
                do
                {
                    numbers.Add(number);
                    counter++;
                } while (counter < m);
            }

            double[] numbersArray = numbers.ToArray();

            return numbersArray;
        }
    }
}
