using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {


            foreach (int number in numbers)
            {

                if (number % divisor == 0)
                {
                    return number;
                }
                else
                {

                }
            }




        }
    }

}
