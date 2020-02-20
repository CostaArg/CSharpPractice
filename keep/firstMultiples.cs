using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            //function that returns an array of the first "m" multiples of a real number "n"
            //eg. multiples(3, 5.0) => [5.0, 10.0, 15.0]

            double[] multiArray = Multiples(10, 5);

            foreach (var item in multiArray)
            {
                Console.WriteLine(item);
            }
        }

        public static double[] Multiples(int m, double n)
        {
            double[] multiArray = new double[m];
            int counter = 0;
            double number = n;

            if (number > 0)
            {
                do
                {
                    multiArray[counter] = number;
                    number += n;
                    counter++;
                } while (number <= m * n);
            }
            else if (number < 0)
            {
                do
                {
                    multiArray[counter] = number;
                    number += n;
                    counter++;
                } while (number >= m * n);
            }
            else
            {
                multiArray[0] = 0;
            }

            return multiArray;
        }
    }
}
